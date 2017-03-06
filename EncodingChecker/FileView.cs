using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ude;

namespace EncodingChecker {
    public partial class FileView : MetroFramework.Forms.MetroForm {
        private const string Unknown = "(Unknown)";

        public FileView() {
            InitializeComponent();
        }
        public void loadFile(string fileName, string encodingName) {
            var encoding = Charsets.GetEncoding(encodingName);
            txtContent.Text = System.IO.File.ReadAllText(fileName, encoding);

            lnkFileName.Text = fileName;
        }
        private void lnkFileName_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("explorer.exe", "/select, \""+ lnkFileName.Text +"\"");
        }
    }
}
