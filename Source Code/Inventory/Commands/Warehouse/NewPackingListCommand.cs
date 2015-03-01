using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;
using System.Data;
using Inventory.DataModels;
//using Inventory.Forms.Warehouse;


namespace Inventory.Commands
{
    public class NewPackingListCommand:Command
    {
        #region Command Member
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                PackingList dlgPackingList = new PackingList();
                dlgPackingList.BindData(null);
                if (DialogResult.Cancel == dlgPackingList.ShowDialog())
                {
                    return;
                }
                objCmd = NewSqlCommand();
                PackingListModel dm = dlgPackingList.DataModel;
                PackingNoteProcess pr = new PackingNoteProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                DialogResult rs = MessageBox.Show("Do you want to create a Delivery note", "",MessageBoxButtons.YesNo);

                //If user would like to create a delivery note then
                //skip step adjust to Location_master
                if (rs == DialogResult.Yes)
                {
                    pr.NewPackingListNoAdjust();
                    objCmd.Transaction.Commit();
                    objCmd.Connection.Close();

                    objCmd = NewSqlCommand();
                    
                    DeliveryNotes dlgNewNote = new DeliveryNotes();
                    DeliveryNoteModel dmDeliverNote = new DeliveryNoteModel();
                    dmDeliverNote.Details = Mediator.GetInstance().GetEmptyDeliveryNoteDetail();

                    foreach (DataRow dr in dm.PackingDetails.Rows)
                    {
                        DataRow drNew = dmDeliverNote.Details.NewRow();
                        //Set the default value of fields
                        for (int i = 0; i < drNew.ItemArray.Length; i++)
                        {
                            if (dmDeliverNote.Details.Columns[i].DataType == typeof(String))
                            {
                                drNew[i] = String.Empty;
                            }
                            else if (dmDeliverNote.Details.Columns[i].DataType == typeof(Decimal))
                            {
                                drNew[i] = 0;
                            }
                            else
                            {
                                drNew[i] = null;
                            }
                        }
                        
                        drNew["Warehouse"] = dr["Warehouse"];
                        drNew["Location"] = dr["Location"];
                        drNew["Product"] = dr["Product"];
                        drNew["Quantity"] = dr["Quantity"];
                        dmDeliverNote.Details.Rows.Add(drNew);
                    }

                    //dmDeliverNote.Details = dm.PackingDetails;

                    dlgNewNote.BindData(dmDeliverNote);

                    if (DialogResult.Cancel == dlgNewNote.ShowDialog())
                    {
                        return;
                    }
                    dmDeliverNote = dlgNewNote.DataModel;

                    DeliveryNoteProcess pr1 = new DeliveryNoteProcess();

                    pr1.DBCommand = objCmd;
                    pr1.DataIn = dmDeliverNote;

                    pr1.NewDeliveryNote();
                }
                else
                {
                    pr.NewPackingList();
                }

                objCmd.Transaction.Commit();
                MessageBox.Show(Constants.Message.Save_Success, Constants.Message.MessageTitle);
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }
                MessageBox.Show(strMessage, Constants.Message.MessageTitle);

                if (objCmd != null)
                {
                    objCmd.Transaction.Rollback();                    
                }                
            }
            finally
            {
                if (objCmd != null)
                {
                    objCmd.Connection.Close();
                }
            }
        }
        #endregion
    }
}
