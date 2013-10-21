namespace FileSort
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDestination = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Sort";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(122, 103);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(108, 13);
            this.lblFolder.TabIndex = 1;
            this.lblFolder.Text = "Please select a folder";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(122, 66);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(95, 13);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "Please select a file";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(27, 61);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(85, 23);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Reference File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(27, 98);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(85, 23);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Source Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(125, 158);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(27, 127);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(85, 23);
            this.btnDestination.TabIndex = 8;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(122, 132);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(108, 13);
            this.lblDestination.TabIndex = 7;
            this.lblDestination.Text = "Please select a folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 156);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // picLoader
            // 
            this.picLoader.Image = global::FileSort.Properties.Resources.ajax_loader;
            this.picLoader.Location = new System.Drawing.Point(11, 16);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(569, 168);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 10;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 193);
            this.Controls.Add(this.picLoader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLoader;
    }
}

