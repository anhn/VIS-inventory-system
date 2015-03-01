using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.Utils.Barcode;
using System.Data.SqlClient;
using Inventory.DataModels.Barcode;

namespace Inventory.DataObjects.DAO
{
    public class BarcodeDao : DBInteractionBase
    {
        /// <summary>
        /// Select Barcodes
        /// </summary>
        /// <returns></returns>
        public DataTable SelectBarcodes()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from BarcodeMaster";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dt = new DataTable("BarcodeMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query.
                sdaAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Barcode::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public void AddNewBarcode(BarcodeModel objBarcodeModel)
        {
            BarcodeGenerator objBarcodeGenerator = new BarcodeGenerator();

            //Byte[] arrBarcodeInfo = objBarcodeGenerator.GetCode39Bytes(objBarcodeModel);
            
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Insert Into BarcodeMaster(ID,Size,Label,ViewState,CreationDate,Description) Values(@Id,@Size,@Label,@ViewState,@CreationDate,@Description)";
            scmCmdToExecute.CommandType = CommandType.Text;

            scmCmdToExecute.Parameters.AddWithValue("@Id", objBarcodeModel.BarcodeId);
            scmCmdToExecute.Parameters.AddWithValue("@Size", objBarcodeModel.Size);
            scmCmdToExecute.Parameters.AddWithValue("@Label", objBarcodeModel.Label);
            scmCmdToExecute.Parameters.AddWithValue("@CreationDate", objBarcodeModel.CreationDate);
            //scmCmdToExecute.Parameters.AddWithValue("@BarcodeInfo", arrBarcodeInfo);
            scmCmdToExecute.Parameters.AddWithValue("@ViewState", objBarcodeModel.ViewStatus);
            scmCmdToExecute.Parameters.AddWithValue("@Description", objBarcodeModel.Description);

            //DataTable dtToReturn = new DataTable("BarcodeMaster");
            //SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //sdaAdapter.Fill(dtToReturn);

                //return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Barcode::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }

        /// <summary>
        /// Select Barcodes
        /// </summary>
        /// <returns></returns>
        public BarcodeModel SelectBarcodeBy(string strID)
        {
            SqlDataReader sdrReader;
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from BarcodeMaster where ID = @Id";
            scmCmdToExecute.CommandType = CommandType.Text;
            //Transfer param
            scmCmdToExecute.Parameters.Add("@Id", strID);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query
                sdrReader = scmCmdToExecute.ExecuteReader();

                BarcodeModel objBarcodeModel = new BarcodeModel();

                if(sdrReader.Read())
                {
                    objBarcodeModel.BarcodeId   = sdrReader["ID"].ToString();
                    objBarcodeModel.Size        = (int)sdrReader["Size"];
                    objBarcodeModel.Label       = sdrReader["Label"].ToString();
                    objBarcodeModel.CreationDate = (DateTime)sdrReader["CreattionDate"];
                    //objBarcodeModel.BarcodeInfo = (byte[])sdrReader["BarcodeInfo"];
                    objBarcodeModel.ViewStatus  = (bool)sdrReader["ViewStatus"];
                    objBarcodeModel.Description = sdrReader["Description"].ToString();
                }

                return objBarcodeModel;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Barcode::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }
    }
}
