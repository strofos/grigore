namespace GrigoreDetection
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
            this.pictureBoxRoboBoard = new System.Windows.Forms.PictureBox();
            this.buttonParseImage1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParseImage2 = new System.Windows.Forms.Button();
            this.buttonParseImage3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxOrig = new System.Windows.Forms.PictureBox();
            this.labelImagePath1 = new System.Windows.Forms.Label();
            this.buttonBrowseImage1 = new System.Windows.Forms.Button();
            this.labelImagePath2 = new System.Windows.Forms.Label();
            this.buttonBrowseImage2 = new System.Windows.Forms.Button();
            this.labelImagePath3 = new System.Windows.Forms.Label();
            this.buttonBrowseImage3 = new System.Windows.Forms.Button();
            this.labelBasePath = new System.Windows.Forms.Label();
            this.buttonBrowseBaseImage = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoboBoard)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrig)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRoboBoard
            // 
            this.pictureBoxRoboBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxRoboBoard.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxRoboBoard.Name = "pictureBoxRoboBoard";
            this.pictureBoxRoboBoard.Size = new System.Drawing.Size(640, 400);
            this.pictureBoxRoboBoard.TabIndex = 0;
            this.pictureBoxRoboBoard.TabStop = false;
            // 
            // buttonParseImage1
            // 
            this.buttonParseImage1.Location = new System.Drawing.Point(273, 37);
            this.buttonParseImage1.Name = "buttonParseImage1";
            this.buttonParseImage1.Size = new System.Drawing.Size(53, 23);
            this.buttonParseImage1.TabIndex = 1;
            this.buttonParseImage1.Text = "Parse";
            this.buttonParseImage1.UseVisualStyleBackColor = true;
            this.buttonParseImage1.Click += new System.EventHandler(this.buttonParseImage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base image:";
            // 
            // buttonParseImage2
            // 
            this.buttonParseImage2.Location = new System.Drawing.Point(273, 63);
            this.buttonParseImage2.Name = "buttonParseImage2";
            this.buttonParseImage2.Size = new System.Drawing.Size(53, 23);
            this.buttonParseImage2.TabIndex = 3;
            this.buttonParseImage2.Text = "Parse";
            this.buttonParseImage2.UseVisualStyleBackColor = true;
            this.buttonParseImage2.Click += new System.EventHandler(this.buttonParseImage2_Click);
            // 
            // buttonParseImage3
            // 
            this.buttonParseImage3.Location = new System.Drawing.Point(616, 37);
            this.buttonParseImage3.Name = "buttonParseImage3";
            this.buttonParseImage3.Size = new System.Drawing.Size(53, 23);
            this.buttonParseImage3.TabIndex = 4;
            this.buttonParseImage3.Text = "Parse";
            this.buttonParseImage3.UseVisualStyleBackColor = true;
            this.buttonParseImage3.Click += new System.EventHandler(this.buttonParseImage3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 439);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxRoboBoard);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxOrig);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Original";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOrig
            // 
            this.pictureBoxOrig.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBoxOrig.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxOrig.Name = "pictureBoxOrig";
            this.pictureBoxOrig.Size = new System.Drawing.Size(640, 400);
            this.pictureBoxOrig.TabIndex = 0;
            this.pictureBoxOrig.TabStop = false;
            // 
            // labelImagePath1
            // 
            this.labelImagePath1.AutoSize = true;
            this.labelImagePath1.Location = new System.Drawing.Point(13, 43);
            this.labelImagePath1.Name = "labelImagePath1";
            this.labelImagePath1.Size = new System.Drawing.Size(86, 13);
            this.labelImagePath1.TabIndex = 6;
            this.labelImagePath1.Text = "labelImagePath1";
            // 
            // buttonBrowseImage1
            // 
            this.buttonBrowseImage1.Location = new System.Drawing.Point(214, 37);
            this.buttonBrowseImage1.Name = "buttonBrowseImage1";
            this.buttonBrowseImage1.Size = new System.Drawing.Size(53, 23);
            this.buttonBrowseImage1.TabIndex = 7;
            this.buttonBrowseImage1.Text = "Browse";
            this.buttonBrowseImage1.UseVisualStyleBackColor = true;
            this.buttonBrowseImage1.Click += new System.EventHandler(this.buttonBrowseImage1_Click);
            // 
            // labelImagePath2
            // 
            this.labelImagePath2.AutoSize = true;
            this.labelImagePath2.Location = new System.Drawing.Point(13, 68);
            this.labelImagePath2.Name = "labelImagePath2";
            this.labelImagePath2.Size = new System.Drawing.Size(86, 13);
            this.labelImagePath2.TabIndex = 8;
            this.labelImagePath2.Text = "labelImagePath2";
            // 
            // buttonBrowseImage2
            // 
            this.buttonBrowseImage2.Location = new System.Drawing.Point(214, 63);
            this.buttonBrowseImage2.Name = "buttonBrowseImage2";
            this.buttonBrowseImage2.Size = new System.Drawing.Size(53, 23);
            this.buttonBrowseImage2.TabIndex = 9;
            this.buttonBrowseImage2.Text = "Browse";
            this.buttonBrowseImage2.UseVisualStyleBackColor = true;
            this.buttonBrowseImage2.Click += new System.EventHandler(this.buttonBrowseImage2_Click);
            // 
            // labelImagePath3
            // 
            this.labelImagePath3.AutoSize = true;
            this.labelImagePath3.Location = new System.Drawing.Point(354, 42);
            this.labelImagePath3.Name = "labelImagePath3";
            this.labelImagePath3.Size = new System.Drawing.Size(86, 13);
            this.labelImagePath3.TabIndex = 10;
            this.labelImagePath3.Text = "labelImagePath3";
            // 
            // buttonBrowseImage3
            // 
            this.buttonBrowseImage3.Location = new System.Drawing.Point(557, 37);
            this.buttonBrowseImage3.Name = "buttonBrowseImage3";
            this.buttonBrowseImage3.Size = new System.Drawing.Size(53, 23);
            this.buttonBrowseImage3.TabIndex = 11;
            this.buttonBrowseImage3.Text = "Browse";
            this.buttonBrowseImage3.UseVisualStyleBackColor = true;
            this.buttonBrowseImage3.Click += new System.EventHandler(this.buttonBrowseImage3_Click);
            // 
            // labelBasePath
            // 
            this.labelBasePath.AutoSize = true;
            this.labelBasePath.Location = new System.Drawing.Point(84, 17);
            this.labelBasePath.Name = "labelBasePath";
            this.labelBasePath.Size = new System.Drawing.Size(75, 13);
            this.labelBasePath.TabIndex = 12;
            this.labelBasePath.Text = "labelBasePath";
            // 
            // buttonBrowseBaseImage
            // 
            this.buttonBrowseBaseImage.Location = new System.Drawing.Point(273, 12);
            this.buttonBrowseBaseImage.Name = "buttonBrowseBaseImage";
            this.buttonBrowseBaseImage.Size = new System.Drawing.Size(53, 23);
            this.buttonBrowseBaseImage.TabIndex = 13;
            this.buttonBrowseBaseImage.Text = "Browse";
            this.buttonBrowseBaseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseBaseImage.Click += new System.EventHandler(this.buttonBrowseBaseImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 541);
            this.Controls.Add(this.buttonBrowseBaseImage);
            this.Controls.Add(this.labelBasePath);
            this.Controls.Add(this.buttonBrowseImage3);
            this.Controls.Add(this.labelImagePath3);
            this.Controls.Add(this.buttonBrowseImage2);
            this.Controls.Add(this.labelImagePath2);
            this.Controls.Add(this.buttonBrowseImage1);
            this.Controls.Add(this.labelImagePath1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonParseImage3);
            this.Controls.Add(this.buttonParseImage2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonParseImage1);
            this.Name = "Form1";
            this.Text = "Grigore detection test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoboBoard)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRoboBoard;
        private System.Windows.Forms.Button buttonParseImage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonParseImage2;
        private System.Windows.Forms.Button buttonParseImage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxOrig;
        private System.Windows.Forms.Label labelImagePath1;
        private System.Windows.Forms.Button buttonBrowseImage1;
        private System.Windows.Forms.Label labelImagePath2;
        private System.Windows.Forms.Button buttonBrowseImage2;
        private System.Windows.Forms.Label labelImagePath3;
        private System.Windows.Forms.Button buttonBrowseImage3;
        private System.Windows.Forms.Label labelBasePath;
        private System.Windows.Forms.Button buttonBrowseBaseImage;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
    }
}

