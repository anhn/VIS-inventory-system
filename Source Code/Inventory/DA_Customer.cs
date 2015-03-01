using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class DA_Customer
    {
        /// <remarks>
        /// Danh sach du lieu
        /// tham chieu toi bang Customers
        /// </remarks>
        private DataSet dsCustomers;

        // Bien boolean, xac dinh da connect toi CSDL chua
        private bool isConnected = false;

        /// <remarks>Ham khoi tao - Ket noi toi CSDL</remarks>
        public DA_Customer()
        {
            // Khoi tao dsCustomers la null
            dsCustomers = null;
            // Ket noi toi CSDL
            isConnected = Data_Access.Connect();
            this.View();
        }
        /// <remarks>Ham huy doi tuong - Dong ket noi toi CSDL</remarks>
        public void Dispose()
        {
            isConnected = false;
            if (dsCustomers != null)
            {
                dsCustomers.Dispose();
            }
        }

        /// <remarks>Ham huy doi tuong - Dong ket noi toi CSDL</remarks>
        ~DA_Customer()
        {
            isConnected = false;
            if (dsCustomers != null)
            {
                dsCustomers.Dispose();
            }
        }
        /// <remarks>Them ban ghi vao dsCustomers va vao CSDL</remarks>
        public bool Add(Customer cus)
        {
            // Neu dsCustomers la null - Tra ve false
            if (dsCustomers == null)
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

                // Them vao DataSet
                DataRow drNewRow;
                // Xay dung mot datarow moi
                drNewRow = dsCustomers.Tables[0].NewRow();
                // Chuyen du lieu tu Customer vao DataRow
                if (!cus.ToDataRow(drNewRow))
                {
                    sQueryString = this.BuildDeleteCommand(cus.ContactID);
                    Data_Access.DoSqlCommand(sQueryString[0]);
                    Data_Access.DoSqlCommand(sQueryString[1]);
                    return false;
                }
                // Them mot Row moi vao trong DataSet
                dsCustomers.Tables[0].Rows.Add(drNewRow);
                // Tra ve true
                return true;
            }
        }

        /// <summary>
        /// Xoa Customer thoa man xau dieu kien i_sCondition
        /// </summary>
        /// <returns>
        /// true: thanh cong
        /// false: that bai
        /// </returns>
        public bool Delete(string sContactID)
        {
            if (dsCustomers == null)
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

                // Xoa trong dataset
                int index = 0;
                int i;
                int i_rowLength;
                // Lay so luong cac dong trong bang
                i_rowLength = dsCustomers.Tables[0].Rows.Count;
                // Neu bang khong co dong nao
                if (i_rowLength == 0)
                {
                    // Tra ve false
                    return false;
                }

                /* Tim chi so cua Customer trong bang */
                for (i = 0; i < i_rowLength; i++)
                {
                    if ((string)dsCustomers.Tables[0].Rows[i]["ContactID"] == sContactID)
                    {
                        index = i;
                        break;
                    }
                }
                if ((string)dsCustomers.Tables[0].Rows[i]["ContactID"] != sContactID)
                {
                    return false;
                }

                dsCustomers.Tables[0].Rows.RemoveAt(index);
                return true;
            }
        }

        /// <summary>
        /// Cap nhat mot Customer moi
        /// </summary>
        /// <returns>
        /// true: thanh cong
        /// flase: that bai
        /// </returns>
        public bool Update(Customer cus)
        {
            if (dsCustomers == null)
            {
                // Neu dsCustomers la null - tra ve false
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
                i_rowLength = dsCustomers.Tables[0].Rows.Count;
                // Neu bang khong co dong nao
                if (i_rowLength == 0)
                {
                    // Tra ve false
                    return false;
                }

                /*************************************************
                 * Modified by DuongNT
                 * Date: 27/3/2007
                 * *************************************************/
                /* Tim chi so cua Customer trong bang */
                /*for (i = 0; i < i_rowLength; i++)
                {
                    if ((string)dsCustomers.Tables[0].Rows[i]["ContactID"] == cus.ContactID)
                    {
                        index = i;
                        break;
                    }
                }
                if ((string)dsCustomers.Tables[0].Rows[i]["ContactID"] != cus.ContactID)
                {
                    return false;
                }

                // Tao mot dong moi
                DataRow drNewRow;
                drNewRow = dsCustomers.Tables[0].NewRow();
                cus.ToDataRow(drNewRow);
                // Xoa dong cu di
                dsCustomers.Tables[0].Rows.RemoveAt(index);
                // Thay dong moi vao
                dsCustomers.Tables[0].Rows.InsertAt(drNewRow, index);
                 */
                return true;
            }
        }

        /// <remarks>Sinh cau lenh SQL them danh sach cac ban ghi tu dataset vao database</remarks>
        private string[] BuildAddCommand(Customer cus)
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
            sRetVal[0] += "'" + cus.Notes + "'," + cus.ContactGroupID + ",";
            sRetVal[0] += "'" + cus.SubscribeNews + "','" + cus.ViewStatus + "',";
            sRetVal[0] += "'" + cus.UserID + "' );";

            sRetVal[1] = "INSERT INTO CUSTOMERCONTACT( ContactID, Payment_term_id, Tax_code_id,";
            sRetVal[1] += "AccountName, Account_number, Credit_limit, Currency, Balance, Discount,";
            sRetVal[1] += "Parent_id, Tax_agent, Billing_address, Billing_city, Billing_state,";
            sRetVal[1] += "[Billing_country], Billing_zip, Billing_phone, Billing_email,";
            sRetVal[1] += "Shipping_address1, Shipping_city, Shipping_state, [Shipping_country],";
            sRetVal[1] += "Shipping_zip, Shipping_phone, Shipping_email) VALUES (";

            sRetVal[1] += "'" + cus.ContactID + "','" + cus.Payment_term_id + "',";
            sRetVal[1] += "'" + cus.Tax_code_id + "','" + cus.AccountName + "',";
            sRetVal[1] += cus.Account_number + "," + cus.Credit_limit + ",";
            sRetVal[1] += "'" + cus.Currency + "'," + cus.Balance + ",";
            sRetVal[1] += cus.Discount + ",'" + cus.Parent_id + "',";
            sRetVal[1] += "'" + cus.Tax_agent + "','" + cus.Billing_address + "',";
            sRetVal[1] += "'" + cus.Billing_city + "','" + cus.Billing_state + "',";
            sRetVal[1] += "'" + cus.Billing_country + "','" + cus.Billing_zip + "',";
            sRetVal[1] += "'" + cus.Billing_phone + "',";
            sRetVal[1] += "'" + cus.Billing_email + "','" + cus.Shipping_address1 + "',";
            sRetVal[1] += "'" + cus.Shipping_city + "','" + cus.Shipping_state + "',";
            sRetVal[1] += "'" + cus.Shipping_country + "','" + cus.Shipping_zip + "',";
            sRetVal[1] += "'" + cus.Shipping_phone + "','" + cus.Shipping_email + "');";
            return sRetVal;
            //throw new System.NotImplementedException();
        }

        /// <remarks>Sinh cau lenh SQL cap nhat danh sach cac ban ghi tu dataset vao database</remarks>
        private string[] BuildUpdateCommand(Customer cus)
        {
            string[] sRetVal;
            sRetVal = new string[2];
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

            sRetVal[1] = "UPDATE CustomerCONTACT SET ";
            sRetVal[1] += "Payment_term_id = '" + cus.Payment_term_id + "', Tax_code_id = '" + cus.Tax_code_id + "',";
            sRetVal[1] += "AccountName = '" + cus.AccountName + "', Account_number = " + cus.Account_number + ",";
            sRetVal[1] += "Credit_limit = " + cus.Credit_limit + ", Currency = '" + cus.Currency + "',";
            sRetVal[1] += "Balance = " + cus.Balance + ", Discount = " + cus.Discount + ",";
            sRetVal[1] += "Parent_id = '" + cus.Parent_id + "', Tax_agent = '" + cus.Tax_agent + "',";
            sRetVal[1] += "Billing_address = '" + cus.Billing_address + "', Billing_city = '" + cus.Billing_city + "',";
            sRetVal[1] += "Billing_state = '" + cus.Billing_state + "', [Billing_country] = '" + cus.Billing_country + "',";
            sRetVal[1] += "Billing_zip = '" + cus.Billing_zip + "', Billing_phone = '" + cus.Billing_phone + "',";
            sRetVal[1] += "Billing_email = '" + cus.Billing_email + "', Shipping_address1 = '" + cus.Shipping_address1 + "',";
            sRetVal[1] += "Shipping_city = '" + cus.Shipping_city + "', Shipping_state = '" + cus.Shipping_state + "',";
            sRetVal[1] += "[Shipping_country] = '" + cus.Shipping_country + "', Shipping_zip = '" + cus.Shipping_zip + "',";
            sRetVal[1] += "Shipping_phone = '" + cus.Shipping_phone + "', Shipping_email = '" + cus.Shipping_email + "' ";
            sRetVal[1] += " WHERE ContactID = '" + cus.ContactID + "';";

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
            sRetVal[1] = "DELETE FROM CustomerContact WHERE ContactID = '" + sContactID + "';";
            return sRetVal;
        }


        /// <summary>
        /// Tra ve DataSet tham chieu toi VListCustomers
        /// </summary>
        /// <returns>
        /// DataSet tham chieu toi VListCustomers neu thanh cong
        /// null: That bai
        /// </returns>
        public DataSet View()
        {
            if (dsCustomers == null)
            {
                // Neu co the ket noi thanh cong toi CSDL
                // Lam tiep tuc
                if (isConnected)
                {
                    // Neu thuc thi truy van thanh cong
                    if (Data_Access.DoSqlCommand("SELECT * FROM VListCustomers"))
                    {
                        dsCustomers = Data_Access.GetDataSet().Copy();
                        // Tra ve dsCustomers
                        return dsCustomers;
                    }
                    else
                    {
                        // Neu khong thuc thi duoc cau lenh SQL
                        // Tra ve null
                        dsCustomers = null;
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
                return dsCustomers;
            }
            //throw new System.NotImplementedException();

        }

        /// <summary>
        /// Tim kiem Customer theo xau dieu kien
        /// </summary>
        /// <returns>
        /// danh sach ket qua tim duoc neu thanh cong
        /// null: that bai
        /// </returns>
        public DataSet Find(string i_sCondition)
        {
            DataSet dsTemp = null;
            string sSQLCommand;
            sSQLCommand = "SELECT * FROM VListCustomers WHERE " + i_sCondition;
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
