using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Data;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Inventory
{
    class DeleteSQL
    {
        SqlConnection sqlCon; 
        public DeleteSQL(SqlConnection sqlConn)
        {
            sqlCon = sqlConn;


        }
        public void deleteCategory(string ContactCatID)
        {
            //delete from ContactCategory table and CategoryInContact table
            ExecuteQuery("DELETE FROM ContactCategory WHERE ContactCatID = '" + ContactCatID + "'");
            ExecuteQuery("DELETE FROM CategoryInContact WHERE ContactCatID = '" + ContactCatID + "'");
        }
        public void deleteContact(string ContactID)
        {
            //delete from ContactCategory
            ExecuteQuery("DELETE FROM ContactBankAccount WHERE ContactID = '" + ContactID + "'"); 
            ExecuteQuery("DELETE FROM ContactCategory WHERE ContactID = '" + ContactID + "'"); 
            //delete from ContactListForContact
            ExecuteQuery("DELETE FROM ContactListForContact WHERE ContactID = '" + ContactID + "' or ContactPersonID = '"+ContactID+"'"); 
            //ContactNotes
            ExecuteQuery("DELETE FROM ContactNotes WHERE ContactID = '" + ContactID + "'"); 
            //ContactPartner
            //ContactUserDefinedFields
            ExecuteQuery("DELETE FROM ContactUserDefinedFields WHERE ContactID = '" + ContactID + "'");
            //MemberContact
            ExecuteQuery("DELETE FROM MemberContact WHERE ContactID = '" + ContactID + "'");
            //CustomerContact
            ExecuteQuery("DELETE FROM CustomerContact WHERE ContactID = '" + ContactID + "'"); 
            //MemberContact
            ExecuteQuery("DELETE FROM MemberContact WHERE ContactID = '" + ContactID + "'"); 
            //SupplierContact
            ExecuteQuery("DELETE FROM SupplierContact WHERE ContactID = '" + ContactID + "'"); 
            //Contact
            ExecuteQuery("DELETE FROM Contact WHERE ContactID = '" + ContactID + "'"); 
        }
        public void deleteCustomer(string ContactID)
        {
            deleteContact(ContactID);
        }
        public void deleteSuplier(string ContactID)
        {
            deleteContact(ContactID);
        }
        public void deleteMember(string ContactID)
        {
            deleteContact(ContactID);
        }
        public Boolean deleteMembership(string MembershipID)
        {
            //Membership
            DataTable tb = new DataTable();
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT MembershipID FROM MemberContact WHERE MembershipID = '" + MembershipID + "'", sqlCon);
            try
            {
                sqlDA.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("“This record is used by other tables, make sure there is no related record before deleting it");
                return false;
            }
            else
            {
                ExecuteQuery("DELETE FROM Membership WHERE MembershipID = '" + MembershipID + "'");
            }
            return true;
            //MemberContact
            //ExecuteQuery("DELETE FROM MemberContact WHERE MembershipID = '" + MembershipID + "'"); 
        }
        public void deleteUDF(string ContactID,string UDFID)
        {
            //ContactUserDefinedFields
            ExecuteQuery("DELETE FROM ContactUserDefinedFields WHERE ContactID = '" + ContactID +"' and UDFID = '" + UDFID + "'"); 
        }
        public void deleteNotes(string ContactNotesID)
        {
            //ContactNotes
            ExecuteQuery("DELETE FROM ContactNotes WHERE ContactNotesID = '" + ContactNotesID + "'"); 
        }
        public void deleteContactList(string ContactID,string ContactPersonID)
        {
            //ContactListForContact
            ExecuteQuery("DELETE FROM ContactListForContact WHERE ContactID = '" + ContactID + "' and ContactPersonID = '" + ContactPersonID + "'"); 
        }
        public void deleteGroup(string ContactGroupID)
        {
            //ContactGroupInContact

            DataTable tb = new DataTable();
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT ContactID FROM Contact WHERE ContactGroupID = '"+ContactGroupID+"'", sqlCon);
            try
            {
                sqlDA.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            foreach (DataRow dr in tb.Rows)
            {
                deleteContact(dr["ContactID"].ToString());
            }
            ExecuteQuery("DELETE FROM ContactGroupInContact WHERE ContactGroupID = '" + ContactGroupID + "'"); 
        }
        public void deleteMr(string MrID)
        {
            //Mr
            ExecuteQuery("DELETE FROM Mr WHERE MrID = '" + MrID + "'"); 
        }
        public Boolean deletePayment(string Payment_term_id)
        {
            //
            DataTable tb = new DataTable();
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Payment_term_id FROM SupplierContact WHERE Payment_term_id = '" + Payment_term_id + "'", sqlCon);
            try
            {
                sqlDA.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            if (tb.Rows.Count == 0)
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                sqlDA = new SqlDataAdapter("SELECT Payment_term_id FROM CustomerContact WHERE Payment_term_id = '" + Payment_term_id + "'", sqlCon);
                try
                {
                    sqlDA.Fill(tb);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }                
            }
            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("This record is used by other tables, make sure there is no related record before deleting it");
                return false;
            }
            else
            {
                ExecuteQuery("DELETE FROM PaymentTermMaster WHERE ID = '" + Payment_term_id + "'");
            }
            return true;
        }
        public Boolean deleteTax(string Tax_code_id)
        {
            //
            DataTable tb = new DataTable();
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Tax_code_id FROM SupplierContact WHERE Tax_code_id = '" + Tax_code_id + "'", sqlCon);
            try
            {
                sqlDA.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            if (tb.Rows.Count == 0)
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                sqlDA = new SqlDataAdapter("SELECT Tax_code_id FROM CustomerContact WHERE Tax_code_id = '" + Tax_code_id + "'", sqlCon);
                try
                {
                    sqlDA.Fill(tb);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("This record is used by other tables, make sure there is no related record before deleting it");
                return false;
            }
            else
            {
                ExecuteQuery("DELETE FROM Tax_code_master WHERE Tax_code_id = '" + Tax_code_id + "'");
            }
            return true;
        }
        public void deleteTaxType(string TaxTypeID)
        {
            ExecuteQuery("DELETE FROM Tax_code_master WHERE TaxTypeID = '" + TaxTypeID + "'");
            ExecuteQuery("DELETE FROM TaxType WHERE TaxTypeID = '" + TaxTypeID + "'");
        }

        public void deleteContactBankAccount(string ID)
        {
            ExecuteQuery("DELETE FROM ContactBankAccount WHERE ID = '" + ID + "'");
        }
        public void deleteEmail(string ID)
        {
            ExecuteQuery("DELETE FROM EmailQueue WHERE EmailID = '" + ID + "'");
        }

        private int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlCon;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            return 0;
        }
    }

}
