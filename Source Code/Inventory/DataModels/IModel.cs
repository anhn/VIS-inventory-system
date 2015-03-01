using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataObjects;
using System.Collections;

namespace Inventory.DataModels
{
    interface IModel
    {
        ArrayList DeletedDetails { get;}
        ArrayList NewDetails { get;}
        ArrayList ChangedDetails { get;}
        void LoadFromDataBase();
        ICommonDBAccess GetMasterRecord();
        void SaveToDatabase();
        void CopyID(ICommonDBAccess objDB);
        void AnalyzeDetailsChanges();
    }
}
