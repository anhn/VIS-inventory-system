using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using Inventory.DataObjects;

namespace Inventory.Process.Reorder
{
    public class ReorderLevelProcess
    {
        private string strReorder = "";

        public ReorderLevelProcess()
        {
        }

        public void Execute()
        {
            ProductMaster objProduct = new ProductMaster();
            DataTable dtProducts = objProduct.SelectAll();
            if (dtProducts.Rows.Count == 0)
            {
                return;
            }
            
            // calculate Reorder for each product
            foreach (DataRow drProd in dtProducts.Rows)
            {
                double dblReorderLevel = CalculateReorderLevel(drProd);
                double dblQtyOnHand = CalculateQtyOnHand(drProd);

                if (dblQtyOnHand < dblReorderLevel)
                {
                    this.CreateAlert(drProd);
                }
            }

            if (string.IsNullOrEmpty(strReorder))
            {
                return; // no product need to reorder.
            }

            string strContent = "Product Reorder Alert: " + Environment.NewLine + strReorder;

            Utils.EMail mail = new Inventory.Utils.EMail(Properties.Settings.Default.MailReorderSubject, strContent);
            mail.SendEmail();
        }

        private double CalculateReorderLevel(DataRow drProd)
        {
            LeadTimeHistory objHistory = new LeadTimeHistory();
            objHistory.ProductID = drProd["ProductID"].ToString();
            DataTable dtHistoryByProduct = objHistory.SelectAllWProductIDLogic(); 
            
            UsageHistory objUsage = new UsageHistory();
            objUsage.ProductID = drProd["ProductID"].ToString();
            DataTable dtUsageByProduct = objUsage.SelectAllWProductIDLogic();

            double dblAverageLeadTime = this.CalculateAverageLeadTime(dtHistoryByProduct);
            double dblVarianceLeadTime = this.CalculateVarianceLeadTime(dtHistoryByProduct, dblAverageLeadTime);

            double dblAverageUsage = this.CalculateAverageUsage(dtUsageByProduct);
            double dblVarianceUsage = this.CalculateVarianceUsage(dtUsageByProduct, dblAverageUsage);

            double dblSafetyStockFactor = 0;
            try
            {
                dblSafetyStockFactor = Convert.ToInt32(drProd["SafetyStockFactor"]);
            }
            catch { }

            double dblMeanAbsoluteDeviation = Math.Sqrt(dblAverageLeadTime * dblVarianceUsage * dblVarianceUsage + dblAverageUsage * dblAverageUsage * dblVarianceUsage * dblVarianceUsage);
            double dblSafetyStock = dblSafetyStockFactor * dblMeanAbsoluteDeviation;

            double dblReorderLevel = dblAverageLeadTime * dblAverageUsage + dblSafetyStock;
            return dblReorderLevel;
        }

        private double CalculateQtyOnHand(DataRow drProd)
        {
            WarehouseProductMaster objMaster = new WarehouseProductMaster();
            objMaster.Product_id = drProd["ProductID"].ToString();

            DataTable dtMasterByProduct = objMaster.SelectAllWProduct_idLogic();
            double dblSumQtyOnHand = 0;
            foreach(DataRow drMaster in dtMasterByProduct.Rows)
            {
                double dblQty = 0;
                try
                {
                    dblQty = Convert.ToDouble(drMaster["On_hand_qty"]);
                }
                catch { }

                dblSumQtyOnHand += dblQty;
            }

            return dblSumQtyOnHand;
        }

        private double CalculateVarianceLeadTime(DataTable dtHistoryByProduct, double dblAverageLeadTime)
        {
            double dblSumSquareMax = 0;
            double dblSumSquareMin = 0;
            int intLeadMaxCount = 0;
            int intLeadMinCount = 0;

            // for each history of a product
            foreach (DataRow drHstr in dtHistoryByProduct.Rows)
            {
                if (!this.CheckHistoryTimestamp(drHstr))
                {
                    continue;
                }

                int intLeadMax = 0;
                int intLeadMin = 0;
                try
                {
                    intLeadMax = Convert.ToInt32(drHstr["LeadTimeMax"]);
                    intLeadMaxCount++;
                }
                catch { } // leave default 0 value
                try
                {
                    intLeadMin = Convert.ToInt32(drHstr["LeadTimeMin"]);
                    intLeadMinCount++;
                }
                catch { } // leave default 0 value

                dblSumSquareMax += (intLeadMax - dblAverageLeadTime) * (intLeadMax - dblAverageLeadTime);
                dblSumSquareMin += (intLeadMin - dblAverageLeadTime) * (intLeadMin - dblAverageLeadTime);
            }

            if (intLeadMaxCount + intLeadMinCount == 0)
            {
                return 0;
            }

            return Math.Sqrt((dblSumSquareMax + dblSumSquareMin)) / (intLeadMaxCount + intLeadMinCount);
        }

        private double CalculateAverageLeadTime(DataTable dtHistoryByProduct)
        {
            double dblSumLeadMax = 0;
            int intLeadMaxCount = 0;
            double dblSumLeadMin = 0;
            int intCountLeadMin = 0;

            // for each history of a product
            foreach (DataRow drHstr in dtHistoryByProduct.Rows)
            {
                if(!this.CheckHistoryTimestamp(drHstr))
                {
                    continue;
                }

                int intLeadMax = 0;
                int intLeadMin = 0;
                try
                {
                    intLeadMax = Convert.ToInt32(drHstr["LeadTimeMax"]);
                    intLeadMaxCount++;
                }
                catch { } // leave default 0 value
                try
                {
                    intLeadMin = Convert.ToInt32(drHstr["LeadTimeMin"]);
                    intCountLeadMin++;
                }
                catch { } // leave default 0 value

                dblSumLeadMax += intLeadMax;
                dblSumLeadMin += intLeadMin;
            }

            if (intLeadMaxCount + intCountLeadMin == 0)
            {
                return 0;
            }

            return (dblSumLeadMax / intLeadMaxCount + dblSumLeadMin / intCountLeadMin) / 2;
        }

        private double CalculateVarianceUsage(DataTable dtUsageByProduct, double dblAverageUsage)
        {
            double dblSumSquare = 0;
            int intCount = 0;

            // for each history of a product
            foreach (DataRow drUsage in dtUsageByProduct.Rows)
            {
                if (!this.CheckUsageTime(drUsage))
                {
                    continue;
                }

                int intQty = 0;
                try
                {
                    intQty = Convert.ToInt32(drUsage["StockOutQty"]);
                    intCount++;
                }
                catch { } // leave default 0 value

                dblSumSquare += (intQty - dblAverageUsage) * (intQty - dblAverageUsage);
            }

            if (intCount == 0)
            {
                return 0;
            }

            return Math.Sqrt(dblSumSquare) / intCount;
        }
        
        private double CalculateAverageUsage(DataTable dtUsageByProduct)
        {
            double dblSumQty = 0;
            int intCount = 0;

            // for each history of a product
            foreach (DataRow drUsage in dtUsageByProduct.Rows)
            {
                if(!this.CheckUsageTime(drUsage))
                {
                    continue;
                }

                int intQty = 0;
                try
                {
                    intQty = Convert.ToInt32(drUsage["StockOutQty"]);
                    intCount++;
                }
                catch { } // leave default 0 value

                dblSumQty += intQty;
            }

            if (intCount == 0)
            {
                return 0;
            }

            return dblSumQty / intCount;
        }

        private bool CheckHistoryTimestamp(DataRow drLeadTimeHistory)
        {
            DateTime dtTimestamp = DateTime.MinValue;
            try
            {
                dtTimestamp = Convert.ToDateTime(drLeadTimeHistory["Timestamp"]);
            }
            catch { } // leave default Min value

            // check in one year
            if (dtTimestamp.AddYears(1) > DateTime.Now || dtTimestamp < DateTime.Now)
            {
                return true;
            }

            return false;
        }

        private bool CheckUsageTime(DataRow drUsageHistory)
        {
            DateTime dtTimestamp = DateTime.MinValue;
            try
            {
                dtTimestamp = Convert.ToDateTime(drUsageHistory["Time"]);
            }
            catch { } // leave default Min value

            // check in one year
            if (dtTimestamp.AddYears(1) > DateTime.Now || dtTimestamp < DateTime.Now)
            {
                return true;
            }

            return false;
        }

        private int GetQtyToOrder(DataRow drProd)
        {
            string strProductID = drProd["ProductID"].ToString();
            double dblDemandPerMonth = this.GetDemandPerMonth(strProductID);
            
            //TODO: where the CostToPlace is taken.
            double dblCostToPlace = GetCostToPlaceOrder();
            //TODO: default value?
            double dblCostToHold = drProd["HoldingCost"] == DBNull.Value? 0 : Convert.ToDouble(drProd["HoldingCost"]);

            double Qty = Math.Sqrt(2 * dblDemandPerMonth * dblCostToPlace / dblCostToHold);
            return (int)Qty;
        }

        private double GetCostToPlaceOrder()
        {
            return 50;
        }

        private double GetDemandPerMonth(string strProductID)
        {
            UsageHistory objUsage = new UsageHistory();
            objUsage.ProductID = strProductID;
            DataTable dtUsageByProduct = objUsage.SelectAllWProductIDLogic();

            double dblSumQty = 0;

            // for each history of a product
            foreach (DataRow drUsage in dtUsageByProduct.Rows)
            {
                if (!this.CheckUsageTime(drUsage))
                {
                    continue;
                }

                int intQty = 0;
                try
                {
                    intQty = Convert.ToInt32(drUsage["StockOutQty"]);
                }
                catch { } // leave default 0 value

                dblSumQty += intQty;
            }

            return dblSumQty;
        }
        
        private void CreateAlert(DataRow drProd)
        {
            strReorder += "\tProduct Name: " + drProd["ProductName"] + ", Current Stock: " + drProd["Qty"] + ", Safety Level: " + drProd["SafetyLevel"] + ", Reorder Level: " + GetQtyToOrder(drProd) + Environment.NewLine;
        }
    }
}
