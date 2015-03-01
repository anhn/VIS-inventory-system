using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class BL_Customer
    {
        /// <remarks>Doi tuong dung thao tac voi du lieu Customer</remarks>
        DA_Customer daCustomer;

        /// <remarks>Ham khoi tao tao doi tuong daCustomer</remarks>
        public BL_Customer()
        {
            daCustomer = new DA_Customer();
        }

        public void Dispose()
        {
            daCustomer.Dispose();
            daCustomer = null;
        }

        ~BL_Customer()
        {
            this.Dispose();
        }

        /// <remarks>Them ban ghi vao dsCustomers va vao CSDL</remarks>
        public bool Add(Customer cus)
        {
            return daCustomer.Add(cus);
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
            return daCustomer.Update(cus);
        }

        /// <summary>
        /// Xoa Customer thoa man xau dieu kien i_sCondition
        /// </summary>
        /// <returns>
        /// true: thanh cong
        /// false: that bai
        /// </returns>
        public bool Delete(string i_sCondition)
        {
            return daCustomer.Delete(i_sCondition);
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
            return daCustomer.View();
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
            return daCustomer.Find(i_sCondition);
        }
    }
}
