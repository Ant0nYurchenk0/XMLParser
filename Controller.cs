using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace XMLparser
{
    static class ParserController
    {
        static public void OpenFile(string filePath, DataGridView table, TextBox textBox)
        {
            if (GlobalContext.Parser.Strategy == null)
            {
                MessageBox.Show(Constant.STRATEGY_ERROR);
                return;
            }
            try
            {
                GlobalContext.Path = filePath;
                textBox.Text = GlobalContext.Path;
                Service.LoadTable(GlobalContext.Path);
                Service.ShowTable(table);
            }
            catch
            {
                return;
            }
        }
        public static void StrategyButton_CheckedChanged(RadioButton button)
        {
            if (button.Checked == true)
            {
                switch (button.Tag.ToString())
                {
                    case "linq":                        
                        GlobalContext.Parser.setStrategy(new LINQtoXMLStrategy());
                        return;
                    case "sax":
                        GlobalContext.Parser.setStrategy(new SAXAPIstrategy());
                        return;
                    case "dom":
                        GlobalContext.Parser.setStrategy(new DOMAPIstrategy());
                        return;
                }
            }
            GlobalContext.Parser.setStrategy(null);
            
        }
        public static void Filter_CheckedChanged(bool check, ComboBox list )
        {
            try
            {
                if (check == true)
                {
                    list.Enabled = true;
                    list.DataSource = GlobalContext.DataFilters[list.Tag.ToString()].ToList();
                }
                else
                {
                    list.Enabled = false;
                    GlobalContext.ActiveFilters.Remove(list.Tag.ToString());
                    list.SelectedItem = null;
                }
            }
            catch
            {
                MessageBox.Show(Constant.FILE_ERROR);
            }

        }
        public static void List_SelectionChanged(ComboBox list)
        {
            if (list.SelectedItem != null)
            {
                GlobalContext.ActiveFilters[list.Tag.ToString()] = list.Text;
            }
        }
        public static void Search(DataGridView table)
        {
            Service.BuildFilteredData();
            Service.ShowTable(table);
        }
        public static void ClearFilters(CheckBox[] checkBoxes, ComboBox[] lists)
        {
            foreach(var list in lists)
            {
                list.DataSource = null;
            }
            foreach(var CheckBox in checkBoxes)
            {
                CheckBox.Checked = false;
            }
        }
        public static void ExportToHtml(string path, DataGridView table)
        {
            string file = Service.BuildHtml(table);
            File.WriteAllText(path, file);
            Process.Start(@"cmd.exe ", @"/c " + path);
        }
    }
}
