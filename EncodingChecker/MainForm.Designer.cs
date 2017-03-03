namespace EncodingChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblBaseDirectory;
            System.Windows.Forms.Label lblFileMasks;
            System.Windows.Forms.Label lblValidCharsets;
            System.Windows.Forms.ColumnHeader colEncoding;
            System.Windows.Forms.ColumnHeader colFileName;
            System.Windows.Forms.ColumnHeader colDirectory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtBaseDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseDirectories = new System.Windows.Forms.Button();
            this.chkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.txtFileMasks = new System.Windows.Forms.TextBox();
            this.lstValidCharsets = new System.Windows.Forms.CheckedListBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListView();
            this.dlgBrowseDirectories = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.actionProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.actionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSelectDestination = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConvertSelection = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboDestinationEncode = new MetroFramework.Controls.MetroComboBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            lblBaseDirectory = new System.Windows.Forms.Label();
            lblFileMasks = new System.Windows.Forms.Label();
            lblValidCharsets = new System.Windows.Forms.Label();
            colEncoding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseDirectory
            // 
            lblBaseDirectory.AutoSize = true;
            lblBaseDirectory.Location = new System.Drawing.Point(10, 60);
            lblBaseDirectory.Name = "lblBaseDirectory";
            lblBaseDirectory.Size = new System.Drawing.Size(98, 13);
            lblBaseDirectory.TabIndex = 0;
            lblBaseDirectory.Text = "&Directory to check:";
            // 
            // lblFileMasks
            // 
            lblFileMasks.AutoSize = true;
            lblFileMasks.Location = new System.Drawing.Point(13, 110);
            lblFileMasks.Name = "lblFileMasks";
            lblFileMasks.Size = new System.Drawing.Size(149, 13);
            lblFileMasks.TabIndex = 4;
            lblFileMasks.Text = "Enter file &masks (one per line)";
            // 
            // lblValidCharsets
            // 
            lblValidCharsets.AutoSize = true;
            lblValidCharsets.Location = new System.Drawing.Point(223, 110);
            lblValidCharsets.Name = "lblValidCharsets";
            lblValidCharsets.Size = new System.Drawing.Size(133, 13);
            lblValidCharsets.TabIndex = 6;
            lblValidCharsets.Text = "Select valid &character sets";
            // 
            // colEncoding
            // 
            colEncoding.Text = "Encoding";
            colEncoding.Width = 25;
            // 
            // colFileName
            // 
            colFileName.Text = "File name";
            colFileName.Width = 25;
            // 
            // colDirectory
            // 
            colDirectory.Text = "Directory";
            colDirectory.Width = 25;
            // 
            // txtBaseDirectory
            // 
            this.txtBaseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBaseDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtBaseDirectory.Location = new System.Drawing.Point(13, 79);
            this.txtBaseDirectory.Name = "txtBaseDirectory";
            this.txtBaseDirectory.Size = new System.Drawing.Size(865, 21);
            this.txtBaseDirectory.TabIndex = 1;
            // 
            // btnBrowseDirectories
            // 
            this.btnBrowseDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDirectories.Location = new System.Drawing.Point(888, 79);
            this.btnBrowseDirectories.Name = "btnBrowseDirectories";
            this.btnBrowseDirectories.Size = new System.Drawing.Size(30, 21);
            this.btnBrowseDirectories.TabIndex = 2;
            this.btnBrowseDirectories.Text = "....";
            this.btnBrowseDirectories.UseVisualStyleBackColor = true;
            this.btnBrowseDirectories.Click += new System.EventHandler(this.OnBrowseDirectories);
            // 
            // chkIncludeSubdirectories
            // 
            this.chkIncludeSubdirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludeSubdirectories.AutoSize = true;
            this.chkIncludeSubdirectories.Location = new System.Drawing.Point(928, 81);
            this.chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            this.chkIncludeSubdirectories.Size = new System.Drawing.Size(135, 17);
            this.chkIncludeSubdirectories.TabIndex = 3;
            this.chkIncludeSubdirectories.Text = "Include &sub-directories";
            this.chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // txtFileMasks
            // 
            this.txtFileMasks.AcceptsReturn = true;
            this.txtFileMasks.Location = new System.Drawing.Point(13, 128);
            this.txtFileMasks.Multiline = true;
            this.txtFileMasks.Name = "txtFileMasks";
            this.txtFileMasks.Size = new System.Drawing.Size(200, 100);
            this.txtFileMasks.TabIndex = 5;
            this.txtFileMasks.WordWrap = false;
            // 
            // lstValidCharsets
            // 
            this.lstValidCharsets.CheckOnClick = true;
            this.lstValidCharsets.FormattingEnabled = true;
            this.lstValidCharsets.Location = new System.Drawing.Point(223, 128);
            this.lstValidCharsets.Name = "lstValidCharsets";
            this.lstValidCharsets.Size = new System.Drawing.Size(200, 100);
            this.lstValidCharsets.TabIndex = 7;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(433, 177);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "&Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.OnAction);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(433, 205);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "&About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.OnAbout);
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colEncoding,
            colFileName,
            colDirectory});
            this.lstResults.FullRowSelect = true;
            this.lstResults.GridLines = true;
            this.lstResults.Location = new System.Drawing.Point(10, 293);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(1065, 313);
            this.lstResults.TabIndex = 9;
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            this.lstResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstResults_KeyDown);
            this.lstResults.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstResults_KeyUp);
            this.lstResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstResults_MouseDoubleClick);
            // 
            // dlgBrowseDirectories
            // 
            this.dlgBrowseDirectories.Description = "Select the directory that you wish to check:";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionProgress,
            this.actionStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 497);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(700, 22);
            this.statusBar.TabIndex = 12;
            this.statusBar.Visible = false;
            // 
            // actionProgress
            // 
            this.actionProgress.Name = "actionProgress";
            this.actionProgress.Size = new System.Drawing.Size(100, 16);
            this.actionProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // actionStatus
            // 
            this.actionStatus.Name = "actionStatus";
            this.actionStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(433, 148);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "Vie&w";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.OnAction);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(514, 205);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV|*.csv";
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(433, 255);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(30, 23);
            this.btnSelectDestination.TabIndex = 15;
            this.btnSelectDestination.Text = "...";
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 235);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Convert to Directory";
            // 
            // btnConvertSelection
            // 
            this.btnConvertSelection.Location = new System.Drawing.Point(702, 258);
            this.btnConvertSelection.Name = "btnConvertSelection";
            this.btnConvertSelection.Size = new System.Drawing.Size(145, 29);
            this.btnConvertSelection.TabIndex = 18;
            this.btnConvertSelection.Text = "&Convert Selected Files";
            this.btnConvertSelection.Click += new System.EventHandler(this.btnConvertSelection_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(469, 235);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Select new character set";
            // 
            // cboDestinationEncode
            // 
            this.cboDestinationEncode.FormattingEnabled = true;
            this.cboDestinationEncode.ItemHeight = 23;
            this.cboDestinationEncode.Location = new System.Drawing.Point(470, 258);
            this.cboDestinationEncode.Name = "cboDestinationEncode";
            this.cboDestinationEncode.Size = new System.Drawing.Size(226, 29);
            this.cboDestinationEncode.TabIndex = 20;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtDestination.Location = new System.Drawing.Point(13, 255);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(414, 21);
            this.txtDestination.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 638);
            this.Controls.Add(this.cboDestinationEncode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnConvertSelection);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lstValidCharsets);
            this.Controls.Add(lblValidCharsets);
            this.Controls.Add(this.txtFileMasks);
            this.Controls.Add(lblFileMasks);
            this.Controls.Add(this.chkIncludeSubdirectories);
            this.Controls.Add(this.btnBrowseDirectories);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtBaseDirectory);
            this.Controls.Add(lblBaseDirectory);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(525, 350);
            this.Name = "MainForm";
            this.Text = "File Encoding Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaseDirectory;
        private System.Windows.Forms.Button btnBrowseDirectories;
        private System.Windows.Forms.CheckBox chkIncludeSubdirectories;
        private System.Windows.Forms.TextBox txtFileMasks;
        private System.Windows.Forms.CheckedListBox lstValidCharsets;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ListView lstResults;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseDirectories;
        private System.Windows.Forms.ToolStripProgressBar actionProgress;
        private System.Windows.Forms.ToolStripStatusLabel actionStatus;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton btnSelectDestination;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConvertSelection;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboDestinationEncode;
        private System.Windows.Forms.TextBox txtDestination;
    }
}

