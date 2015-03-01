using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Inventory.DataModels.StockTake;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;
using Inventory.DataModels;
using Inventory.Forms.StockTake;

namespace Inventory.Process.StockTake
{
    class StockVarianceProcess
    {
        private PrintVarianceModel model;
        private SqlCommand objCmd;

        public PrintVarianceModel DataIn
        {
            get { return model; }
            set { model = value; }
        }

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public DataTable Run()
        {
            StockVarianceDao objDao = new StockVarianceDao();
            DataTable dtVariance = objDao.GetStockVariance(model.ID);
            
            dtVariance.Columns.Add("Check Quantity"); // add columns
            dtVariance.Columns.Add("Variance %", typeof(decimal));

            if (!string.IsNullOrEmpty(model.SortBy))
            {
                dtVariance.DefaultView.Sort = model.SortBy;
            }

            if (model.ExcludeBothZero)
            {
                ExcludeBothZero(dtVariance);
            }

            // only missing items
            if (model.OnlyMissingItems)
            {
                return GetOnlyMissingItems(dtVariance);
            }

            int intCurrentQty = 0;
            int intCountedQty = 0;
            foreach (DataRow dr in dtVariance.Rows)
            {
                intCurrentQty = (dr["Current Quantity"] == DBNull.Value)? 0 : Convert.ToInt32(dr["Current Quantity"]);
                intCountedQty = (dr["Counted Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Counted Quantity"]);

                // check variance
                if (intCurrentQty != 0)
                {
                    decimal dcmVariance = (intCountedQty - intCurrentQty) * 100 / intCurrentQty;
                    if (dcmVariance < model.Variance)
                    {
                        dr.Delete(); // delete row from table.
                    }
                    else
                    {
                        dr["Variance %"] = Math.Round(dcmVariance); 
                    }
                }
            }

            dtVariance.AcceptChanges();
            
            return dtVariance;
        }

        private DataTable GetOnlyMissingItems(DataTable dtVariance)
        {
            int intCurrentQty = 0;
            int intCountedQty = 0;
            foreach (DataRow dr in dtVariance.Rows)
            {
                intCurrentQty = (dr["Current Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Current Quantity"]);
                intCountedQty = (dr["Counted Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Counted Quantity"]);

                if (intCurrentQty != 0 && intCountedQty != 0) // not missing
                {
                    dr.Delete();
                }
            }

            dtVariance.AcceptChanges();
            return dtVariance;
        }

        private void ExcludeBothZero(DataTable dtVariance)
        {
            int intCurrentQty = 0;
            int intCountedQty = 0;
            foreach (DataRow dr in dtVariance.Rows)
            {
                intCurrentQty = (dr["Current Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Current Quantity"]);
                intCountedQty = (dr["Counted Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Counted Quantity"]);

                if (intCurrentQty == 0 && intCountedQty == 0)
                {
                    dr.Delete(); // delete row from table.
                }
            }

            dtVariance.AcceptChanges();
        }
    }
}
