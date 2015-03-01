using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace Inventory.Utils
{
    class DevXpressUtils
    {
        public static DataRow GetSelectedRow(DevExpress.XtraGrid.GridControl grd)
        {
            GridView view = (GridView)grd.Views[0];
            if (view.SelectedRowsCount == 0) return null;
            int i = view.GetSelectedRows()[0];
            DataRow row = ((DataRowView)view.GetRow(i)).Row;
            return row;
        }
    }
}
