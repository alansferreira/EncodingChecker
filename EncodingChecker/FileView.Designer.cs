namespace EncodingChecker {
    partial class FileView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileView));
            this.txtContent = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lnkFileName = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtContent.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtContent.BackBrush = null;
            this.txtContent.CharHeight = 14;
            this.txtContent.CharWidth = 8;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtContent.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtContent.IsReplaceMode = false;
            this.txtContent.Location = new System.Drawing.Point(23, 63);
            this.txtContent.Name = "txtContent";
            this.txtContent.Paddings = new System.Windows.Forms.Padding(0);
            this.txtContent.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtContent.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtContent.ServiceColors")));
            this.txtContent.Size = new System.Drawing.Size(706, 402);
            this.txtContent.TabIndex = 0;
            this.txtContent.Zoom = 100;
            // 
            // lnkFileName
            // 
            this.lnkFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkFileName.Location = new System.Drawing.Point(23, 483);
            this.lnkFileName.Name = "lnkFileName";
            this.lnkFileName.Size = new System.Drawing.Size(706, 23);
            this.lnkFileName.TabIndex = 1;
            this.lnkFileName.Text = "metroLink1";
            this.lnkFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkFileName.Click += new System.EventHandler(this.lnkFileName_Click);
            // 
            // FileView
            // 
            this.ClientSize = new System.Drawing.Size(752, 509);
            this.Controls.Add(this.lnkFileName);
            this.Controls.Add(this.txtContent);
            this.Name = "FileView";
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox txtContent;
        private MetroFramework.Controls.MetroLink lnkFileName;
    }
}
