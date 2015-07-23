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
            this.buttonParseImage1.Location = new System.Drawing.Point(87, 12);
            this.buttonParseImage1.Name = "buttonParseImage1";
            this.buttonParseImage1.Size = new System.Drawing.Size(33, 23);
            this.buttonParseImage1.TabIndex = 1;
            this.buttonParseImage1.Text = "1";
            this.buttonParseImage1.UseVisualStyleBackColor = true;
            this.buttonParseImage1.Click += new System.EventHandler(this.buttonParseImage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parse image:";
            // 
            // buttonParseImage2
            // 
            this.buttonParseImage2.Location = new System.Drawing.Point(126, 12);
            this.buttonParseImage2.Name = "buttonParseImage2";
            this.buttonParseImage2.Size = new System.Drawing.Size(33, 23);
            this.buttonParseImage2.TabIndex = 3;
            this.buttonParseImage2.Text = "2";
            this.buttonParseImage2.UseVisualStyleBackColor = true;
            this.buttonParseImage2.Click += new System.EventHandler(this.buttonParseImage2_Click);
            // 
            // buttonParseImage3
            // 
            this.buttonParseImage3.Location = new System.Drawing.Point(165, 12);
            this.buttonParseImage3.Name = "buttonParseImage3";
            this.buttonParseImage3.Size = new System.Drawing.Size(33, 23);
            this.buttonParseImage3.TabIndex = 4;
            this.buttonParseImage3.Text = "3";
            this.buttonParseImage3.UseVisualStyleBackColor = true;
            this.buttonParseImage3.Click += new System.EventHandler(this.buttonParseImage3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
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
            this.tabPage2.Size = new System.Drawing.Size(669, 422);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 499);
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
    }
}

