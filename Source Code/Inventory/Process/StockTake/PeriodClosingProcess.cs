using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Inventory.DataModels.StockTake;
using Inventory.DataObjects;
using Inventory.DataModels;
using Inventory.DataObjects.DAO;
using Inventory.Forms.StockTake;

namespace Inventory.Process.StockTake
{
    public class PeriodClosingProcess
    {
        private PeriodClosingModel model;
        private SqlCommand objCmd;
        private PeriodMaster objLastOpenPeriod = new PeriodMaster();
        
        public PeriodClosingModel DataIn
        {
            get { return model; }
            set { model = value; }
        }

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public void ClosePeriod()
        {
            this.GetLastOpenPeriodData();
            objLastOpenPeriod.Description = model.Description;
            objLastOpenPeriod.ViewStatus = model.State;

            PeriodMaster objNextPeriod = this.CreateNextPeriod();

            ProductDetailsDao objProductDetailsDao = new ProductDetailsDao();
            DataTable dtProductDetails = objProductDetailsDao.GetPeriodProductDetails(model.StartDate, model.EndDate);

            //InvoiceMasterDao objInvoiceMasterDao = new InvoiceMasterDao();
            //DataTable dtInvoiceMasters = objInvoiceMasterDao.GetPeriodInvoiceMasters(model.StartDate, model.EndDate);

            Hashtable hshLastPeriodProducts = new Hashtable();
            Hashtable hshNextPeriodProducts = new Hashtable();
            foreach (DataRow drProd in dtProductDetails.Rows)
            {
                string strProductID = (drProd["ProductID"] == DBNull.Value) ? "" : Convert.ToString(drProd["ProductID"]);
                if (string.IsNullOrEmpty(strProductID))
                {
                    continue; // Product Id is not valid
                }

                // get last period detail for this product
                // using cache if this product has been exist (in the current loop)
                PeriodDetails objLastPeriodDetails = null;
                if (hshLastPeriodProducts.ContainsKey(strProductID))
                {
                    objLastPeriodDetails = (PeriodDetails)hshLastPeriodProducts[strProductID];
                }
                else
                {
                    objLastPeriodDetails = this.CreatePeriodDetail(objLastOpenPeriod, strProductID);
                    hshLastPeriodProducts.Add(strProductID, objLastPeriodDetails);
                }

                // get next period detail for this product
                // using cache if this product has been exist (in the current loop)
                PeriodDetails objNextPeriodDetails = null;
                if (hshNextPeriodProducts.ContainsKey(strProductID))
                {
                    objNextPeriodDetails = (PeriodDetails)hshNextPeriodProducts[strProductID];
                }
                else
                {
                    objNextPeriodDetails = this.CreatePeriodDetail(objNextPeriod, strProductID);
                    hshNextPeriodProducts.Add(strProductID, objNextPeriodDetails);
                }

                // get Qty and Transaction Type of current product
                int intQty = (drProd["Qty"] == DBNull.Value) ? 0 : Convert.ToInt32(drProd["Qty"]);
                bool blnTransType = (drProd["TransactionType"] == DBNull.Value) ? false : Convert.ToBoolean(drProd["TransactionType"]);
                if (blnTransType)
                {
                    objLastPeriodDetails.OutputQty += intQty; // out
                    objLastPeriodDetails.CloseQty -= intQty; // subtract from close Qty
                }
                else
                {
                    objLastPeriodDetails.InputQty += intQty; // in
                    objLastPeriodDetails.CloseQty += intQty; // add to close Qty
                }

                // transfer close qty of last period to open qty of next period
                objNextPeriodDetails.OpenQty = objLastPeriodDetails.CloseQty;

                // save period details for current product
                objLastPeriodDetails.Update(objCmd);
                if (objNextPeriodDetails.OpenQty < 0)
                {
                    // do not create next period detail if close Qty of
                    // last period (open Qty of next period) is less than 0
                    objNextPeriodDetails.Delete(objCmd);
                }
            }


            // save last period
            objLastOpenPeriod.Status = Constants.PeriodClosing.CloseStatus;
            objLastOpenPeriod.Update(objCmd);

            // save next period
            objNextPeriod.Update(objCmd);
        }

        

        private void GetLastOpenPeriodData()
        {
            PeriodClosingDao objDao = new PeriodClosingDao();
            
            // get data to objMaster
            DataTable dt = objDao.SelectLastOpenPeriodData(objLastOpenPeriod, model.Type);
            if (dt.Rows.Count > 0) // data exist
            {
                if (!model.StartDate.Equals(objLastOpenPeriod.StartDate.Value)
                    || !model.EndDate.Equals(objLastOpenPeriod.EndDate.Value))
                {
                    throw new Exception(Constants.Message.PeriodClosing_PreviewPeriodNotClosed);
                }

                //objLastOpenPeriodDetail = new PeriodDetails();
                //objLastOpenPeriodDetail.PeriodMasterID = objLastOpenPeriod.ID;
                //objLastOpenPeriodDetail.SelectAllWPeriodMasterIDLogic(); // get detail
            }
            else
            {
                // the first time close period, create the first period
                objLastOpenPeriod = this.CreateFirstPeriod();
                //objLastOpenPeriodDetail = this.CreatePeriodDetail(objLastOpenPeriod);
            }
        }

        private PeriodMaster CreateFirstPeriod()
        {
            // create period
            PeriodMaster objMaster = new PeriodMaster();
            objMaster.ID = Guid.NewGuid().ToString();

            objMaster.PeriodTypeID = model.Type; // same type to current period
            objMaster.Status = Constants.PeriodClosing.OpenStatus; // period is open
            objMaster.StartDate = model.StartDate; // start date of next period is end date of preview period
            objMaster.EndDate = model.EndDate; // set end date to Max value.

            objMaster.ViewStatus = model.State;
            objMaster.Insert(objCmd);
            return objMaster;
        }

        private PeriodMaster CreateNextPeriod()
        {
            // create next period
            PeriodMaster objMaster = new PeriodMaster();
            objMaster.ID = Guid.NewGuid().ToString();
            
            objMaster.PeriodTypeID = model.Type; // same type to current period
            objMaster.Status = Constants.PeriodClosing.OpenStatus; // period is open
            objMaster.StartDate = model.EndDate.AddSeconds(1); // start date of next period is end date of preview period

            objMaster.EndDate = Utils.DateUtils.GetPeriodEndDate(objMaster.StartDate.Value, model.TypeName);
            
            objMaster.ViewStatus = true;
            objMaster.Insert(objCmd);
            return objMaster;
        }

        private PeriodDetails CreatePeriodDetail(PeriodMaster master, string productID)
        {
            PeriodDetails objDetail = new PeriodDetails();
            objDetail.ID = Guid.NewGuid().ToString();
            objDetail.PeriodMasterID = master.ID;
            objDetail.ProductID = productID;

            objDetail.CloseQty = 0;
            objDetail.Cost = 0;
            objDetail.InputQty = 0;
            objDetail.OpenQty = 0;
            objDetail.OutputQty = 0;
            objDetail.Price = 0;

            objDetail.ViewSatus = master.ViewStatus;
            objDetail.Insert(objCmd);
            return objDetail;
        }
    }
}
