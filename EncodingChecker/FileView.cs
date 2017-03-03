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
        public FileView() {
            InitializeComponent();
        }
        public void loadFile(string fileName, string encode) {
            if (string.IsNullOrEmpty(encode)) {
                txtContent.Text = System.IO.File.ReadAllText(fileName);
            } else {
                txtContent.Text = System.IO.File.ReadAllText(fileName, Encoding.GetEncoding(encode));
            }
        }
        private void lnkFileName_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("explorer.exe /select, \""+ lnkFileName.Text +"\"");
        }
    }
}
