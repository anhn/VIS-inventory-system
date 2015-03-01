using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class DA_Supplier
    {
        /// <remarks>
        /// Danh sach du lieu
        /// tham chieu toi bang Suppliers
        /// </remarks>
        private DataSet dsSuppliers;

        // Bien boolean, xac dinh da connect toi CSDL chua
        private bool isConnected = false;

        /// <remarks>Ham khoi tao - Ket noi toi CSDL</remarks>
        public DA_Supplier()
        {
            // Khoi tao dsSuppliers la null
            dsSuppliers = null;
            // Ket noi toi CSDL
            isConnected = Data_Access.Connect();
            View();
        }
        /// <remarks>Ham huy doi tuong - Dong ket noi toi CSDL</remarks>
        public void Dispose()
        {
            isConnected = false;
            if (dsSuppliers != null)
            {
                dsSuppliers.Dispose();
            }
        }

        /// <remarks>Ham huy doi tuong - Dong ket noi toi CSDL</remarks>
        ~DA_Supplier()
        {
            isConnected = false;
            if (dsSuppliers != null)
            {
                dsSuppliers.Dispose();
            }
        }
        /// <remarks>Them ban ghi vao dsCustomers va vao CSDL</remarks>
        public bool Add(Supplier cus)
        {
            // Neu dsSuppliers la null - Tra ve false
            if (dsSuppliers == null)
            {
                return false;
            }
            else
            {
                // Them vao CSDL
                string[] sQueryString;
                sQueryString = this.BuildAddCommand(cus);
                if (isConnected)
                {
                    if (!Data_Access.DoSqlCommand(sQueryString[0]))
                    {
                        // Neu khong thuc hien duoc truy van
                        // Tra ve false
                        return false;
                    }
                    if (!Data_Access.DoSqlCommand(sQueryString[1]))
                    {
                        // Neu khong thuc hien duoc truy van
                        // Tra ve false
                        return false;
                    }
                }
                else
                {
                    // Neu chua ket noi toi CSDL tra ve false
                    return false;
                }
                /*
                // Them vao DataSet
                DataRow drNewRow;
                // Xay dung mot datarow moi
                drNewRow = dsSuppliers.Tables[0].NewRow();
                // Chuyen du lieu tu Supplier vao DataRow
                if (!cus.ToDataRow(drNewRow))
                {
                    sQueryString = this.BuildDeleteCommand(cus.ContactID);
                    Data_Access.DoSqlCommand(sQueryString[0]);
                    Data_Access.DoSqlCommand(sQueryString[1]);
                    return false;
                }
                // Them mot Row moi vao trong DataSet
                dsSuppliers.Tables[0].Rows.Add(drNewRow);*/
                // Tra ve true
                return true;
            }
        }

        /// <summary>
        /// Xoa supplier thoa man xau dieu kien i_sCondition
        /// </summary>
        /// <returns>
        /// true: thanh cong
        /// false: that bai
        /// </returns>
        public bool Delete(string sContactID)
        {
            if (dsSuppliers == null)
            {
                return false;
            }
            else
            {
                // Xoa trong CSDL
                string[] sQueryString;
                sQueryString = this.BuildDeleteCommand(sContactID);
                if (isConnected)
                {
                    if (!Data_Access.DoSqlCommand(sQueryString[0]))
                    {
                        return false;
                    }
                    if (!Data_Access.DoSqlCommand(sQueryString[1]))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                /*
                // Xoa trong dataset
                int index = 0;
                int i;
                int i_rowLength;
                // Lay so luong cac dong trong bang
                i_rowLength = dsSuppliers.Tables[0].Rows.Count;
                // Neu bang khong co dong nao
                if (i_rowLength == 0)
                {
                    // Tra ve false
                    return false;
                }

                DataRow[] rows = dsSuppliers.Tables[0].Select("[Contact ID] = '" + sContactID + "'");
                if (rows.Length > 0) rows[0].Delete();
                else return false;
                */
                return true;
            }
        }
        
        /// <summary>
        /// Cap nhat mot Supplier moi
        /// </summary>
        /// <returns>
        /// true: thanh cong
        /// flase: that bai
        /// </returns>
        public bool Update(Supplier cus)
        {
            if (dsSuppliers == null)
            {
                // Neu dsSuppliers la null - tra ve false
                return false;
            }
            else
            {
                // Thay doi trong CSDL
                string[] sQueryString;
                // Xay dung xau truy van UPDATE
                sQueryString = this.BuildUpdateCommand(cus);
                if (isConnected)
                {
                    if (!Data_Access.DoSqlCommand(sQueryString[0]))
                    {
                        // Neu khong thuc hien duoc cau truy van
                        // Tra ve false
                        return false;
                    }
                    if (!Data_Access.DoSqlCommand(sQueryString[1]))
                    {
                        // Neu khong thuc hien duoc cau truy van
                        // Tra ve false
                        return false;
                    }
                }
                else
                {
                    // Neu chua ket noi toi CSDL 
                    // tra ve false
                    return false;
                }

                // Thay doi trong DataSet
                int index = 0;
                int i;
                int i_rowLength;
                // Lay so luong cac dong trong bang
                i_rowLength = dsSuppliers.Tables[0].Rows.Count;
                // Neu bang khong co dong nao
                if (i_rowLength == 0)
                {
                    // Tra ve false
                    return false;
                }

                /* Tim chi so cua Supplier trong bang */
               /* for (i = 0; i < i_rowLength; i++)
                {
                    if ((string)dsSuppliers.Tables[0].Rows[i]["ContactID"] == cus.ContactID)
                    {
                        index = i;
                        break;
                    }
                }
                if ((string)dsSuppliers.Tables[0].Rows[i]["ContactID"] != cus.ContactID)
                {
                    return false;
                }

                // Tao mot dong moi
                DataRow drNewRow;
                drNewRow = dsSuppliers.Tables[0].NewRow();
                cus.ToDataRow(drNewRow);
                // Xoa dong cu di
                dsSuppliers.Tables[0].Rows.RemoveAt(index);
                // Thay dong moi vao
                dsSuppliers.Tables[0].Rows.InsertAt(drNewRow, index);*/
                return true;
            }
        }

        /// <remarks>Sinh cau lenh SQL them danh sach cac ban ghi tu dataset vao database</remarks>
        private string[] BuildAddCommand(Supplier cus)
        {
            string[] sRetVal;
            sRetVal = new string[2];
            sRetVal[0] = "INSERT INTO Contact(ContactID, Mr,";
            sRetVal[0] += "FirstName, MiddleName, LastName, EmailName, ";
            sRetVal[0] += "ContactName, CompanyName, Alt_contact, ";
            sRetVal[0] += "Address1, Address2, ";
            sRetVal[0] += "City, Province, Zip, Country, Phone1, ";
            sRetVal[0] += "Phone2, Fax1, Fax2, Cell1, Cell2, Email1, ";
            sRetVal[0] += "Email2, Email3, Website,";
            sRetVal[0] += "Notes, ContactGroupID, SubscribeNews,";
            sRetVal[0] += "ViewStatus, UserID) VALUES ( ";

            sRetVal[0] += "'" + cus.ContactID + "',";
            sRetVal[0] += "'" + cus.Mr + "','" + cus.FirstName + "',";
            sRetVal[0] += "'" + cus.MiddleName + "','" + cus.LastName + "',";
            sRetVal[0] += "'" + cus.EmailName + "','" + cus.ContactName + "',";
            sRetVal[0] += "'" + cus.CompanyName + "','" + cus.Alt_contact + "',";
            sRetVal[0] += "'" + cus.Address1 + "',";
            sRetVal[0] += "'" + cus.Address2 + "','" + cus.City + "',";
            sRetVal[0] += "'" + cus.Province + "','" + cus.Zip + "',";
            sRetVal[0] += "'" + cus.Country + "','" + cus.Phone1 + "',";
            sRetVal[0] += "'" + cus.Phone2 + "','" + cus.Fax1 + "',";
            sRetVal[0] += "'" + cus.Fax2 + "','" + cus.Cell1 + "',";
            sRetVal[0] += "'" + cus.Cell2 + "','" + cus.Email1 + "',";
            sRetVal[0] += "'" + cus.Email2 + "','" + cus.Email3 + "',";
            sRetVal[0] += "'" + cus.Website + "',";
            sRetVal[0] += "'" + cus.Notes + "'," + 3 + ",";
            sRetVal[0] += "'" + cus.SubscribeNews + "','" + cus.ViewStatus + "',";
            sRetVal[0] += "'" + cus.UserID + "' );";
            
            sRetVal[1] = "INSERT INTO SUPPLIERCONTACT( ContactID, Payment_term_id, Tax_code_id,";
            sRetVal[1] += "AccountName, Account_number, Credit_limit, Currency, Balance, Discount,";
            sRetVal[1] += "Parent_id, Tax_agent) VALUES( ";
            
            sRetVal[1] += "'" + cus.ContactID + "','" + cus.Payment_term_id + "',";
            sRetVal[1] += "'" + cus.Tax_code_id + "','" + cus.AccountName +"',";
            sRetVal[1] += cus.Account_number + "," + cus.Credit_limit + ",";
            sRetVal[1] += "'" + cus.Currency + "'," + cus.Balance + ",";
            sRetVal[1] += cus.Discount + ",'" + cus.Parent_id + "',";
            sRetVal[1] += "'" + cus.Tax_agent + "' );";
            return sRetVal;
            //throw new System.NotImplementedException();
        }

        /// <remarks>Sinh cau lenh SQL cap nhat danh sach cac ban ghi tu dataset vao database</remarks>
        private string[] BuildUpdateCommand(Supplier cus)
        {
            string[] sRetVal;
            sRetVal = new string [2];
            sRetVal[0] = "UPDATE Contact SET ";
            sRetVal[0] += "Website = '" + cus.Website + "', Mr = '" + cus.Mr + "',";
            sRetVal[0] += "FirstName = '" + cus.FirstName + "', MiddleName = '" + cus.MiddleName + "',";
            sRetVal[0] += "LastName = '" + cus.LastName + "', Emailname = '" + cus.EmailName + "',";
            sRetVal[0] += "ContactName = '" + cus.ContactName + "', CompanyName = '" + cus.CompanyName + "',";
            sRetVal[0] += "Alt_contact = '" + cus.Alt_contact + "', Address1 = '" + cus.Address1 + "',";
            sRetVal[0] += "Address2 = '" + cus.Address2 + "', City = '" + cus.City + "',";
            sRetVal[0] += "Province = '" + cus.Province + "', Zip = '" + cus.Zip + "',";
            sRetVal[0] += "Country = '" + cus.Country + "', Phone1 = '" + cus.Phone1 + "',";
            sRetVal[0] += "Phone2 = '" + cus.Phone2 + "', Fax1 = '" + cus.Fax1 + "',";
            sRetVal[0] += "Fax2 = '" + cus.Fax2 + "', Cell1 = '" + cus.Cell1 + "',";
            sRetVal[0] += "Cell2 = '" + cus.Cell2 + "', Email1 = '" + cus.Email1 + "',";
            sRetVal[0] += "Email2 = '" + cus.Email2 + "', Email3 = '" + cus.Email3 + "',";
            sRetVal[0] += "Notes = '" + cus.Notes + "', SubscribeNews = '" + cus.SubscribeNews + "',";
            sRetVal[0] += "ContactGroupID = " + cus.ContactGroupID + ", ViewStatus = '" + cus.ViewStatus + "',";
            sRetVal[0] += "UserID = '" + cus.UserID + "' ";
            sRetVal[0] += "WHERE ContactID = '" + cus.ContactID + "';";

            sRetVal[1] = "UPDATE SUPPLIERCONTACT SET ";
            sRetVal[1] += "Payment_term_id = '" + cus.Payment_term_id + "', Tax_code_id = '" + cus.Tax_code_id + "',";
            sRetVal[1] += "AccountName = '" + cus.AccountName + "', Account_number = " + cus.Account_number + ",";
            sRetVal[1] += "Credit_limit = " + cus.Credit_limit + ", Currency = '" + cus.Currency + "',";
            sRetVal[1] += "Balance = " + cus.Balance + ", Discount = " + cus.Discount + ",";
            sRetVal[1] += "Parent_id = '" + cus.Parent_id + "', Tax_agent = '" + cus.Tax_agent + "' ";
            sRetVal[1] += "WHERE ContactID = '" + cus.ContactID + "';";

            return sRetVal;
            //throw new System.NotImplementedException();
        }

        /// <remarks>Sinh cau lenh SQL Xoa danh sach cac ban ghi co  trong database</remarks>
        private string[] BuildDeleteCommand(string sContactID)
        {
            //throw new System.NotImplementedException();
            string[] sRetVal;
            sRetVal = new string[2];
            sRetVal[0] = "DELETE FROM Contact WHERE ContactID = '" + sContactID + "';";
            sRetVal[1] = "DELETE FROM SupplierContact WHERE ContactID = '" + sContactID + "';";
            return sRetVal;
        }

        
        /// <summary>
        /// Tra ve DataSet tham chieu toi VListSuppliers
        /// </summary>
        /// <returns>
        /// DataSet tham chieu toi VListSuppliers neu thanh cong
        /// null: That bai
        /// </returns>
        public DataSet View()
        {
            if (dsSuppliers == null)
            {
                // Neu co the ket noi thanh cong toi CSDL
                // Lam tiep tuc
                if (isConnected)
                {
                    // Neu thuc thi truy van thanh cong
                    if (Data_Access.DoSqlCommand("SELECT * FROM VListSuppliers"))
                    {
                        dsSuppliers = Data_Access.GetDataSet().Copy();
                        // Tra ve dsSuppliers
                        return dsSuppliers;
                    }
                    else
                    {
                        // Neu khong thuc thi duoc cau lenh SQL
                        // Tra ve null
                        dsSuppliers = null;
                        return null;
                    }
                }
                else
                {
                    // Neu khong the ket noi -> Tra ve null
                    return null;
                }
            }
            else
            {
                return dsSuppliers;
            }
            //throw new System.NotImplementedException();

        }

        /// <summary>
        /// Tim kiem Supplier theo xau dieu kien
        /// </summary>
        /// <returns>
        /// danh sach ket qua tim duoc neu thanh cong
        /// null: that bai
        /// </returns>
        public DataSet Find(string i_sCondition)
        {
            DataSet dsTemp = null;
            string sSQLCommand;
            sSQLCommand = "SELECT * FROM VListSuppliers WHERE " + i_sCondition;
            if (isConnected)
            {
                if (Data_Access.DoSqlCommand(sSQLCommand))
                {
                    dsTemp = Data_Access.GetDataSet().Copy();
                    return dsTemp;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
