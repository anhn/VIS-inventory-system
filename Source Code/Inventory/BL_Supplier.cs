using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class BL_Supplier
    {
        /// <remarks>Doi tuong dung thao tac voi du lieu Supplier</remarks>
        DA_Supplier daSupplier;

        /// <remarks>Ham khoi tao tao doi tuong daSupplier</remarks>
        public BL_Supplier()
        {
            daSupplier = new DA_Supplier();
        }

        public void Dispose()
        {
            daSupplier.Dispose();
            daSupplier = null;
        }

        ~BL_Supplier()
        {
            this.Dispose();
        }

        /// <remarks>Them ban ghi vao dsSuppliers va vao CSDL</remarks>
        public bool Add(Supplier cus)
        {
            return daSupplier.Add(cus);
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
            return daSupplier.Update(cus);
        }

        /// <summary>
        /// Xoa Supplier thoa man xau dieu kien i_sCondition
        /// </summary>
        /// <returns>
        /// true: thanh cong
        /// false: that bai
        /// </returns>
        public bool Delete(string i_sCondition)
        {
            return daSupplier.Delete(i_sCondition);
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
            return daSupplier.View();
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
            return daSupplier.Find(i_sCondition);
        }
    }
}
