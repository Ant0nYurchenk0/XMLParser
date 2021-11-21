using System;
using System.Windows.Forms;

namespace XMLparser
{
    public partial class XMLParserForm : Form
    {
        private CheckBox[] filterCheckBoxes; 
        private ComboBox[] filterListBoxes; 
        public XMLParserForm()
        {
            InitializeComponent();
            OpenXMLFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            SaveAsHTML.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            filterCheckBoxes = new CheckBox[]{ NameFilter, DepartmentFilter, SchoolFilter, YearFilter, DateJoinedFilter, AddressFilter};
            filterListBoxes = new ComboBox[]{ NameList, DepartmentList, SchoolList, YearList, DateJoinedList, AddressList};

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenXMLFile.ShowDialog() == DialogResult.Cancel)
                return;
            ParserController.OpenFile(OpenXMLFile.FileName, 
                                            TableView, 
                                            FilePathTextBox);
            ParserController.ClearFilters(filterCheckBoxes, filterListBoxes);
        }

        private void LINQtoXMLbutton_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.StrategyButton_CheckedChanged(LINQtoXMLbutton);
        }

        private void SAXAPIbutton_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.StrategyButton_CheckedChanged(SAXAPIbutton);
        }

        private void DOMAPIbutton_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.StrategyButton_CheckedChanged(DOMAPIbutton);
        }

        private void NameFilter_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.Filter_CheckedChanged(NameFilter.Checked, NameList);
        }

        private void YearFilter_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.Filter_CheckedChanged(YearFilter.Checked, YearList);
        }

        private void SchoolFilter_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.Filter_CheckedChanged(SchoolFilter.Checked, SchoolList);

        }

        private void DepartmentFilter_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.Filter_CheckedChanged(DepartmentFilter.Checked, DepartmentList);

        }

        private void DateJoinedFilter_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.Filter_CheckedChanged(DateJoinedFilter.Checked, DateJoinedList);
        }

        private void AddressFilter_CheckedChanged(object sender, EventArgs e)
        {
            ParserController.Filter_CheckedChanged(AddressFilter.Checked, AddressList);
        }

        private void NameList_SelectedValueChanged(object sender, EventArgs e)
        {
            ParserController.List_SelectionChanged(NameList);

        }

        private void YearList_SelectedValueChanged(object sender, EventArgs e)
        {
            ParserController.List_SelectionChanged(YearList);

        }

        private void SchoolList_SelectedValueChanged(object sender, EventArgs e)
        {
            ParserController.List_SelectionChanged(SchoolList);

        }

        private void DepartmentList_SelectedValueChanged(object sender, EventArgs e)
        {
            ParserController.List_SelectionChanged(DepartmentList); 

        }

        private void DateJoinedFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            ParserController.List_SelectionChanged(DateJoinedList); 
        }

        private void AddressList_SelectedValueChanged(object sender, EventArgs e)
        {
            ParserController.List_SelectionChanged(AddressList); 
        }

        private void ReOpenBtn_Click(object sender, EventArgs e)
        {
            ParserController.OpenFile(GlobalContext.Path, TableView, FilePathTextBox);
            ParserController.ClearFilters(filterCheckBoxes, filterListBoxes);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ParserController.Search(TableView);
        }

        private void htmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveAsHTML.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            ParserController.ExportToHtml(SaveAsHTML.FileName, TableView);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
            form.Dispose();
        }

    }
}
