using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSort {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnFolder_Click(object sender, EventArgs e) {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                lblFolder.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void btnFile_Click(object sender, EventArgs e) {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                lblFile.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnRun_Click(object sender, EventArgs e) {
            string file = lblFile.Text;
            string folder = lblFolder.Text;
            string destination = lblDestination.Text;
            Sorter sortClass = new Sorter();
            try {
                //sortClass.ReadFile(file);
                sortClass.SortFiles(sortClass.ReadFile(file), folder, destination);
            } catch (Exception ex) {

                MessageBox.Show("Something went Wrong " + ex.Message);
            }
        }

        private void btnDestination_Click(object sender, EventArgs e) {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                lblDestination.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }


    }
}