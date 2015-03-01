using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Inventory.Forms.Binder
{
    class XTagItem
    {
        public string Value;
        public string Display;
        public XTagItem(string value, string display)
        {
            Value = value;
            Display = display;

        }
        public override string ToString()
        {
            return Display;
        }

        static public XTagItem GetItemByValue(CollectionBase tabCollection, string strValue)
        {
            foreach (XTagItem item in tabCollection)
            {
                if (item.Value.Equals(strValue))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
