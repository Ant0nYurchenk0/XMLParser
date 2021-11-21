using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace XMLparser
{
    public static class DataGridHelper
    {
        public static object GetCellValueFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;
        }
    }
}
