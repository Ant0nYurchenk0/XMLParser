
namespace XMLparser
{
    partial class XMLParserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameList = new System.Windows.Forms.ComboBox();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.OpenXMLFile = new System.Windows.Forms.OpenFileDialog();
            this.ParserMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LINQtoXMLbutton = new System.Windows.Forms.RadioButton();
            this.SAXAPIbutton = new System.Windows.Forms.RadioButton();
            this.DOMAPIbutton = new System.Windows.Forms.RadioButton();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.NameFilter = new System.Windows.Forms.CheckBox();
            this.YearFilter = new System.Windows.Forms.CheckBox();
            this.SchoolFilter = new System.Windows.Forms.CheckBox();
            this.DepartmentFilter = new System.Windows.Forms.CheckBox();
            this.YearList = new System.Windows.Forms.ComboBox();
            this.SchoolList = new System.Windows.Forms.ComboBox();
            this.DepartmentList = new System.Windows.Forms.ComboBox();
            this.ReOpenBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.StrategyLabel = new System.Windows.Forms.Label();
            this.SaveAsHTML = new System.Windows.Forms.SaveFileDialog();
            this.DateJoinedList = new System.Windows.Forms.ComboBox();
            this.AddressList = new System.Windows.Forms.ComboBox();
            this.DateJoinedFilter = new System.Windows.Forms.CheckBox();
            this.AddressFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.ParserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameList
            // 
            this.NameList.Enabled = false;
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(112, 155);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(205, 23);
            this.NameList.TabIndex = 14;
            this.NameList.Tag = "Name";
            this.NameList.SelectedValueChanged += new System.EventHandler(this.NameList_SelectedValueChanged);
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.BackgroundColor = System.Drawing.Color.Silver;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(323, 68);
            this.TableView.Name = "TableView";
            this.TableView.RowTemplate.Height = 25;
            this.TableView.Size = new System.Drawing.Size(726, 370);
            this.TableView.TabIndex = 1;
            // 
            // ParserMenu
            // 
            this.ParserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ParserMenu.Location = new System.Drawing.Point(0, 0);
            this.ParserMenu.Name = "ParserMenu";
            this.ParserMenu.Size = new System.Drawing.Size(1061, 24);
            this.ParserMenu.TabIndex = 5;
            this.ParserMenu.Text = "ParserMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlFileToolStripMenuItem});
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exportAsToolStripMenuItem.Text = "Export As...";
            // 
            // htmlFileToolStripMenuItem
            // 
            this.htmlFileToolStripMenuItem.Name = "htmlFileToolStripMenuItem";
            this.htmlFileToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.htmlFileToolStripMenuItem.Text = "html file";
            this.htmlFileToolStripMenuItem.Click += new System.EventHandler(this.htmlFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LINQtoXMLbutton
            // 
            this.LINQtoXMLbutton.AutoSize = true;
            this.LINQtoXMLbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LINQtoXMLbutton.Location = new System.Drawing.Point(12, 70);
            this.LINQtoXMLbutton.Name = "LINQtoXMLbutton";
            this.LINQtoXMLbutton.Size = new System.Drawing.Size(122, 25);
            this.LINQtoXMLbutton.TabIndex = 6;
            this.LINQtoXMLbutton.TabStop = true;
            this.LINQtoXMLbutton.Tag = "linq";
            this.LINQtoXMLbutton.Text = "LINQ to XML";
            this.LINQtoXMLbutton.UseVisualStyleBackColor = true;
            this.LINQtoXMLbutton.CheckedChanged += new System.EventHandler(this.LINQtoXMLbutton_CheckedChanged);
            // 
            // SAXAPIbutton
            // 
            this.SAXAPIbutton.AutoSize = true;
            this.SAXAPIbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SAXAPIbutton.Location = new System.Drawing.Point(140, 71);
            this.SAXAPIbutton.Name = "SAXAPIbutton";
            this.SAXAPIbutton.Size = new System.Drawing.Size(81, 24);
            this.SAXAPIbutton.TabIndex = 7;
            this.SAXAPIbutton.TabStop = true;
            this.SAXAPIbutton.Tag = "sax";
            this.SAXAPIbutton.Text = "SAX API";
            this.SAXAPIbutton.UseVisualStyleBackColor = true;
            this.SAXAPIbutton.CheckedChanged += new System.EventHandler(this.SAXAPIbutton_CheckedChanged);
            // 
            // DOMAPIbutton
            // 
            this.DOMAPIbutton.AutoSize = true;
            this.DOMAPIbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DOMAPIbutton.Location = new System.Drawing.Point(227, 71);
            this.DOMAPIbutton.Name = "DOMAPIbutton";
            this.DOMAPIbutton.Size = new System.Drawing.Size(90, 24);
            this.DOMAPIbutton.TabIndex = 8;
            this.DOMAPIbutton.TabStop = true;
            this.DOMAPIbutton.Tag = "dom";
            this.DOMAPIbutton.Text = "DOM API";
            this.DOMAPIbutton.UseVisualStyleBackColor = true;
            this.DOMAPIbutton.CheckedChanged += new System.EventHandler(this.DOMAPIbutton_CheckedChanged);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.FilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FilePathTextBox.Location = new System.Drawing.Point(333, 50);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(511, 15);
            this.FilePathTextBox.TabIndex = 9;
            this.FilePathTextBox.Text = "File path...";
            // 
            // NameFilter
            // 
            this.NameFilter.AutoSize = true;
            this.NameFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameFilter.Location = new System.Drawing.Point(12, 155);
            this.NameFilter.Name = "NameFilter";
            this.NameFilter.Size = new System.Drawing.Size(63, 21);
            this.NameFilter.TabIndex = 10;
            this.NameFilter.Text = "Name";
            this.NameFilter.UseVisualStyleBackColor = true;
            this.NameFilter.CheckedChanged += new System.EventHandler(this.NameFilter_CheckedChanged);
            // 
            // YearFilter
            // 
            this.YearFilter.AutoSize = true;
            this.YearFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YearFilter.Location = new System.Drawing.Point(12, 195);
            this.YearFilter.Name = "YearFilter";
            this.YearFilter.Size = new System.Drawing.Size(53, 21);
            this.YearFilter.TabIndex = 11;
            this.YearFilter.Text = "Year";
            this.YearFilter.UseVisualStyleBackColor = true;
            this.YearFilter.CheckedChanged += new System.EventHandler(this.YearFilter_CheckedChanged);
            // 
            // SchoolFilter
            // 
            this.SchoolFilter.AutoSize = true;
            this.SchoolFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SchoolFilter.Location = new System.Drawing.Point(12, 237);
            this.SchoolFilter.Name = "SchoolFilter";
            this.SchoolFilter.Size = new System.Drawing.Size(67, 21);
            this.SchoolFilter.TabIndex = 12;
            this.SchoolFilter.Text = "School";
            this.SchoolFilter.UseVisualStyleBackColor = true;
            this.SchoolFilter.CheckedChanged += new System.EventHandler(this.SchoolFilter_CheckedChanged);
            // 
            // DepartmentFilter
            // 
            this.DepartmentFilter.AutoSize = true;
            this.DepartmentFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepartmentFilter.Location = new System.Drawing.Point(12, 280);
            this.DepartmentFilter.Name = "DepartmentFilter";
            this.DepartmentFilter.Size = new System.Drawing.Size(100, 21);
            this.DepartmentFilter.TabIndex = 13;
            this.DepartmentFilter.Text = "Department";
            this.DepartmentFilter.UseVisualStyleBackColor = true;
            this.DepartmentFilter.CheckedChanged += new System.EventHandler(this.DepartmentFilter_CheckedChanged);
            // 
            // YearList
            // 
            this.YearList.Enabled = false;
            this.YearList.FormattingEnabled = true;
            this.YearList.Location = new System.Drawing.Point(112, 195);
            this.YearList.Name = "YearList";
            this.YearList.Size = new System.Drawing.Size(205, 23);
            this.YearList.TabIndex = 15;
            this.YearList.Tag = "Year";
            this.YearList.SelectedValueChanged += new System.EventHandler(this.YearList_SelectedValueChanged);
            // 
            // SchoolList
            // 
            this.SchoolList.Enabled = false;
            this.SchoolList.FormattingEnabled = true;
            this.SchoolList.Location = new System.Drawing.Point(112, 237);
            this.SchoolList.Name = "SchoolList";
            this.SchoolList.Size = new System.Drawing.Size(205, 23);
            this.SchoolList.TabIndex = 16;
            this.SchoolList.Tag = "School";
            this.SchoolList.SelectedValueChanged += new System.EventHandler(this.SchoolList_SelectedValueChanged);
            // 
            // DepartmentList
            // 
            this.DepartmentList.Enabled = false;
            this.DepartmentList.FormattingEnabled = true;
            this.DepartmentList.Location = new System.Drawing.Point(112, 280);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.Size = new System.Drawing.Size(205, 23);
            this.DepartmentList.TabIndex = 17;
            this.DepartmentList.Tag = "Department";
            this.DepartmentList.SelectedValueChanged += new System.EventHandler(this.DepartmentList_SelectedValueChanged);
            // 
            // ReOpenBtn
            // 
            this.ReOpenBtn.Location = new System.Drawing.Point(12, 101);
            this.ReOpenBtn.Name = "ReOpenBtn";
            this.ReOpenBtn.Size = new System.Drawing.Size(148, 38);
            this.ReOpenBtn.TabIndex = 18;
            this.ReOpenBtn.Text = "Reopen";
            this.ReOpenBtn.UseVisualStyleBackColor = true;
            this.ReOpenBtn.Click += new System.EventHandler(this.ReOpenBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(169, 101);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(148, 38);
            this.SearchBtn.TabIndex = 19;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // StrategyLabel
            // 
            this.StrategyLabel.AutoSize = true;
            this.StrategyLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.StrategyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StrategyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StrategyLabel.Location = new System.Drawing.Point(1, 36);
            this.StrategyLabel.Name = "StrategyLabel";
            this.StrategyLabel.Size = new System.Drawing.Size(175, 25);
            this.StrategyLabel.TabIndex = 20;
            this.StrategyLabel.Text = "Select parsing tool:";
            // 
            // DateJoinedList
            // 
            this.DateJoinedList.Enabled = false;
            this.DateJoinedList.FormattingEnabled = true;
            this.DateJoinedList.Location = new System.Drawing.Point(112, 323);
            this.DateJoinedList.Name = "DateJoinedList";
            this.DateJoinedList.Size = new System.Drawing.Size(205, 23);
            this.DateJoinedList.TabIndex = 21;
            this.DateJoinedList.Tag = "DateJoined";
            this.DateJoinedList.SelectedValueChanged += new System.EventHandler(this.DateJoinedFilter_SelectedValueChanged);
            // 
            // AddressList
            // 
            this.AddressList.Enabled = false;
            this.AddressList.FormattingEnabled = true;
            this.AddressList.Location = new System.Drawing.Point(112, 365);
            this.AddressList.Name = "AddressList";
            this.AddressList.Size = new System.Drawing.Size(205, 23);
            this.AddressList.TabIndex = 22;
            this.AddressList.Tag = "Address";
            this.AddressList.SelectedValueChanged += new System.EventHandler(this.AddressList_SelectedValueChanged);
            // 
            // DateJoinedFilter
            // 
            this.DateJoinedFilter.AutoSize = true;
            this.DateJoinedFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateJoinedFilter.Location = new System.Drawing.Point(12, 323);
            this.DateJoinedFilter.Name = "DateJoinedFilter";
            this.DateJoinedFilter.Size = new System.Drawing.Size(98, 21);
            this.DateJoinedFilter.TabIndex = 23;
            this.DateJoinedFilter.Text = "Date Joined";
            this.DateJoinedFilter.UseVisualStyleBackColor = true;
            this.DateJoinedFilter.CheckedChanged += new System.EventHandler(this.DateJoinedFilter_CheckedChanged);
            // 
            // AddressFilter
            // 
            this.AddressFilter.AutoSize = true;
            this.AddressFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressFilter.Location = new System.Drawing.Point(12, 365);
            this.AddressFilter.Name = "AddressFilter";
            this.AddressFilter.Size = new System.Drawing.Size(76, 21);
            this.AddressFilter.TabIndex = 24;
            this.AddressFilter.Text = "Address";
            this.AddressFilter.UseVisualStyleBackColor = true;
            this.AddressFilter.CheckedChanged += new System.EventHandler(this.AddressFilter_CheckedChanged);
            // 
            // XMLParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.AddressFilter);
            this.Controls.Add(this.DateJoinedFilter);
            this.Controls.Add(this.AddressList);
            this.Controls.Add(this.DateJoinedList);
            this.Controls.Add(this.StrategyLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ReOpenBtn);
            this.Controls.Add(this.DepartmentList);
            this.Controls.Add(this.SchoolList);
            this.Controls.Add(this.YearList);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.DepartmentFilter);
            this.Controls.Add(this.SchoolFilter);
            this.Controls.Add(this.YearFilter);
            this.Controls.Add(this.NameFilter);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.DOMAPIbutton);
            this.Controls.Add(this.SAXAPIbutton);
            this.Controls.Add(this.LINQtoXMLbutton);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.ParserMenu);
            this.MainMenuStrip = this.ParserMenu;
            this.Name = "XMLParserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMLParser";
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ParserMenu.ResumeLayout(false);
            this.ParserMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.OpenFileDialog OpenXMLFile;
        private System.Windows.Forms.MenuStrip ParserMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlFileToolStripMenuItem;
        private System.Windows.Forms.RadioButton LINQtoXMLbutton;
        private System.Windows.Forms.RadioButton SAXAPIbutton;
        private System.Windows.Forms.RadioButton DOMAPIbutton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.CheckBox NameFilter;
        private System.Windows.Forms.CheckBox YearFilter;
        private System.Windows.Forms.CheckBox SchoolFilter;
        private System.Windows.Forms.CheckBox DepartmentFilter;
        private System.Windows.Forms.ComboBox NameList;
        private System.Windows.Forms.ComboBox YearList;
        private System.Windows.Forms.ComboBox SchoolList;
        private System.Windows.Forms.ComboBox DepartmentList;
        private System.Windows.Forms.Button ReOpenBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label StrategyLabel;
        private System.Windows.Forms.SaveFileDialog SaveAsHTML;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox DateJoinedList;
        private System.Windows.Forms.ComboBox AddressList;
        private System.Windows.Forms.CheckBox DateJoinedFilter;
        private System.Windows.Forms.CheckBox AddressFilter;
    }
}

