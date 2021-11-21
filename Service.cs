using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XMLparser
{
    static class Service
    {
        public static void LoadTable(string path)
        {
            GlobalContext.Data = GlobalContext.Parser.Parse(path);            
            GlobalContext.FilteredData = GlobalContext.Data.Select(student => new StudentClass(student)).ToList();            
        }
        public static void ShowTable(DataGridView table)
        {
            if (GlobalContext.FilteredData == null )
            {
                return;
            }
            table.Rows.Clear();
            table.Columns.Clear();
            CreateColumns(table);
            table.RowHeadersWidth = Constant.ROW_HEADER_WIDTH;
            CreateRows(table);
            InitFiltersData();
        }
        public static void BuildFilteredData()
        {
            GlobalContext.FilteredData.Clear();
            foreach(var student in GlobalContext.Data)
            {
                var filters = GlobalContext.ActiveFilters;
                if (filters.TryGetValue("Name", out var name))
                {
                    if (student.Name != name) continue;
                }
                if (filters.TryGetValue("Year", out var year))
                {
                    if (student.Year.ToString() != year) continue;
                }
                if (filters.TryGetValue("Department", out var department))
                {
                    if (student.Department != department) continue;
                }
                if (filters.TryGetValue("School", out var school))
                {
                    if (student.School != school) continue;
                }
                if (filters.TryGetValue("Address", out var address))
                {
                    if (student.Address != address) continue;
                }
                if (filters.TryGetValue("DateJoined", out var dateJoined))
                {
                    if (student.DateJoined.ToShortDateString() != dateJoined) continue;
                }
                GlobalContext.FilteredData.Add(student);
            }
        }
        public static string BuildHtml(DataGridView table)
        {
            string result = string.Empty;
            result += Constant.HTML_BEGIN;
            result += "<tr>\n";
            foreach(DataGridViewColumn header in table.Columns)
            {
                result += ("<th>" + header.HeaderText + "</th>\n");
            }
            result += "</tr>\n";
            foreach(DataGridViewRow row in table.Rows)
            {
                result += "<tr>\n";
                foreach(DataGridViewCell cell in row.Cells)
                {
                    result += ("<td>" + cell.Value +"</td>\n");
                }
                result += "</tr>\n";
            }
            result += Constant.HTML_END;
            return result;
        }
        private static void InitFiltersData()
        {
            foreach(var student in GlobalContext.Data)
            {
                if(GlobalContext.DataFilters.Count != GlobalContext.Fields.Length)
                {
                    InitFilters();
                }
                GlobalContext.DataFilters["Name"].Add(student.Name);
                GlobalContext.DataFilters["School"].Add(student.School);
                GlobalContext.DataFilters["Department"].Add(student.Department);
                GlobalContext.DataFilters["Year"].Add(student.Year.ToString());
                GlobalContext.DataFilters["Address"].Add(student.Address);
                GlobalContext.DataFilters["DateJoined"].Add(student.DateJoined.ToShortDateString());
            }
        }
        private static void InitFilters()
        {
            GlobalContext.DataFilters.Clear();
            GlobalContext.DataFilters.Add("Name", new HashSet<string>());
            GlobalContext.DataFilters.Add("School", new HashSet<string>());
            GlobalContext.DataFilters.Add("Department", new HashSet<string>());
            GlobalContext.DataFilters.Add("Year", new HashSet<string>());
            GlobalContext.DataFilters.Add("Address", new HashSet<string>());
            GlobalContext.DataFilters.Add("DateJoined", new HashSet<string>());
        }
        private static void CreateColumns(DataGridView table)
        {
            foreach(var header in GlobalContext.Fields)
            {
                var column = new DataGridViewTextBoxColumn();
                column.Name = header.ToString();
                column.HeaderCell.Value = column.Name;
                table.Columns.Add(column);
            }
            table.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private static void CreateRows(DataGridView table)
        {
            foreach (var student in GlobalContext.FilteredData)
            {
                var row = new DataGridViewRow();
                row.HeaderCell.Value = (table.RowCount + 1).ToString();
                table.Rows.Add(row);
                table.Rows[table.RowCount - 1].Cells["Name"].Value = student.Name;
                table.Rows[table.RowCount - 1].Cells["Year"].Value = student.Year;
                table.Rows[table.RowCount - 1].Cells["School"].Value = student.School;
                table.Rows[table.RowCount - 1].Cells["Department"].Value = student.Department;
                table.Rows[table.RowCount - 1].Cells["Date Joined"].Value = student.DateJoined.ToShortDateString();
                table.Rows[table.RowCount - 1].Cells["Address"].Value = student.Address;
            }
        }
    }

}
