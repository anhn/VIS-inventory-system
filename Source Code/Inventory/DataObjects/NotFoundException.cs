using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataObjects
{
    class NotFoundException : Exception
    {
        string strMsg;
        public override String Message
        {
            get { return strMsg; }
        }

        public NotFoundException(String str)
        {
            strMsg = str;
        }
    }
}
