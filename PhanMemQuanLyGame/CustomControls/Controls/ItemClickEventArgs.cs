using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControls.Controls
{
    public class ItemClickEventArgs : EventArgs
    {
        public string ItemID { get; }

        public ItemClickEventArgs(string itemID)
        {
            ItemID = itemID;
        }
    }
}
