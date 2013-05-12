using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CvConsole
{
    public static class ListViewItemExtension
    {
        internal static ListViewItem CloneWithName(this ListViewItem item)
        {
            ListViewItem clonedItem = item.Clone() as ListViewItem;
            clonedItem.Name = clonedItem.Text;
            return clonedItem;
        }
    }
}
