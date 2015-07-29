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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxGenerated = new System.Windows.Forms.PictureBox();
            this.buttonBrowseRobotImage = new System.Windows.Forms.Button();
            this.labelRobotImagePath = new System.Windows.Forms.Label();
            this.buttonMoveFw = new System.Windows.Forms.Button();
            this.buttonMoveRv = new System.Windows.Forms.Button();
            this.buttonTurnLeft = new System.Windows.Forms.Button();
            this.buttonTurnRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDegree = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelDetection = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDetectedPosition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDetectionOffset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoboBoard)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrig)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGenerated)).BeginInit();
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
            this.buttonParseImage1.Location = new System.Drawing.Point(912, 53);
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
            this.buttonParseImage2.Location = new System.Drawing.Point(912, 82);
            this.buttonParseImage2.Name = "buttonParseImage2";
            this.buttonParseImage2.Size = new System.Drawing.Size(53, 23);
            this.buttonParseImage2.TabIndex = 3;
            this.buttonParseImage2.Text = "Parse";
            this.buttonParseImage2.UseVisualStyleBackColor = true;
            this.buttonParseImage2.Click += new System.EventHandler(this.buttonParseImage2_Click);
            // 
            // buttonParseImage3
            // 
            this.buttonParseImage3.Location = new System.Drawing.Point(912, 111);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 439);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelDetection);
            this.tabPage1.Controls.Add(this.pictureBoxRoboBoard);
            this.tabPage1.Controls.Add(this.buttonBrowseImage1);
            this.tabPage1.Controls.Add(this.buttonBrowseImage3);
            this.tabPage1.Controls.Add(this.buttonParseImage1);
            this.tabPage1.Controls.Add(this.labelImagePath3);
            this.tabPage1.Controls.Add(this.buttonParseImage2);
            this.tabPage1.Controls.Add(this.buttonParseImage3);
            this.tabPage1.Controls.Add(this.buttonBrowseImage2);
            this.tabPage1.Controls.Add(this.labelImagePath1);
            this.tabPage1.Controls.Add(this.labelImagePath2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 413);
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
            this.tabPage2.Size = new System.Drawing.Size(975, 413);
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
            this.labelImagePath1.Location = new System.Drawing.Point(652, 59);
            this.labelImagePath1.Name = "labelImagePath1";
            this.labelImagePath1.Size = new System.Drawing.Size(86, 13);
            this.labelImagePath1.TabIndex = 6;
            this.labelImagePath1.Text = "labelImagePath1";
            // 
            // buttonBrowseImage1
            // 
            this.buttonBrowseImage1.Location = new System.Drawing.Point(853, 53);
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
            this.labelImagePath2.Location = new System.Drawing.Point(652, 87);
            this.labelImagePath2.Name = "labelImagePath2";
            this.labelImagePath2.Size = new System.Drawing.Size(86, 13);
            this.labelImagePath2.TabIndex = 8;
            this.labelImagePath2.Text = "labelImagePath2";
            // 
            // buttonBrowseImage2
            // 
            this.buttonBrowseImage2.Location = new System.Drawing.Point(853, 82);
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
            this.labelImagePath3.Location = new System.Drawing.Point(650, 116);
            this.labelImagePath3.Name = "labelImagePath3";
            this.labelImagePath3.Size = new System.Drawing.Size(86, 13);
            this.labelImagePath3.TabIndex = 10;
            this.labelImagePath3.Text = "labelImagePath3";
            // 
            // buttonBrowseImage3
            // 
            this.buttonBrowseImage3.Location = new System.Drawing.Point(853, 111);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelDetectionOffset);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.labelDetectedPosition);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.labelPosition);
            this.tabPage3.Controls.Add(this.labelDegree);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonTurnRight);
            this.tabPage3.Controls.Add(this.buttonTurnLeft);
            this.tabPage3.Controls.Add(this.buttonMoveRv);
            this.tabPage3.Controls.Add(this.buttonMoveFw);
            this.tabPage3.Controls.Add(this.buttonBrowseRobotImage);
            this.tabPage3.Controls.Add(this.labelRobotImagePath);
            this.tabPage3.Controls.Add(this.pictureBoxGenerated);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(975, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate layout";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGenerated
            // 
            this.pictureBoxGenerated.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxGenerated.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxGenerated.Name = "pictureBoxGenerated";
            this.pictureBoxGenerated.Size = new System.Drawing.Size(640, 400);
            this.pictureBoxGenerated.TabIndex = 0;
            this.pictureBoxGenerated.TabStop = false;
            // 
            // buttonBrowseRobotImage
            // 
            this.buttonBrowseRobotImage.Location = new System.Drawing.Point(916, 7);
            this.buttonBrowseRobotImage.Name = "buttonBrowseRobotImage";
            this.buttonBrowseRobotImage.Size = new System.Drawing.Size(53, 23);
            this.buttonBrowseRobotImage.TabIndex = 9;
            this.buttonBrowseRobotImage.Text = "Browse";
            this.buttonBrowseRobotImage.UseVisualStyleBackColor = true;
            this.buttonBrowseRobotImage.Click += new System.EventHandler(this.buttonBrowseRobotImage_Click);
            // 
            // labelRobotImagePath
            // 
            this.labelRobotImagePath.AutoSize = true;
            this.labelRobotImagePath.Location = new System.Drawing.Point(654, 12);
            this.labelRobotImagePath.Name = "labelRobotImagePath";
            this.labelRobotImagePath.Size = new System.Drawing.Size(109, 13);
            this.labelRobotImagePath.TabIndex = 8;
            this.labelRobotImagePath.Text = "labelRobotImagePath";
            // 
            // buttonMoveFw
            // 
            this.buttonMoveFw.Location = new System.Drawing.Point(773, 139);
            this.buttonMoveFw.Name = "buttonMoveFw";
            this.buttonMoveFw.Size = new System.Drawing.Size(75, 55);
            this.buttonMoveFw.TabIndex = 10;
            this.buttonMoveFw.Text = "FW";
            this.buttonMoveFw.UseVisualStyleBackColor = true;
            this.buttonMoveFw.Click += new System.EventHandler(this.buttonMoveFw_Click);
            // 
            // buttonMoveRv
            // 
            this.buttonMoveRv.Location = new System.Drawing.Point(773, 220);
            this.buttonMoveRv.Name = "buttonMoveRv";
            this.buttonMoveRv.Size = new System.Drawing.Size(75, 55);
            this.buttonMoveRv.TabIndex = 11;
            this.buttonMoveRv.Text = "RV";
            this.buttonMoveRv.UseVisualStyleBackColor = true;
            this.buttonMoveRv.Click += new System.EventHandler(this.buttonMoveRv_Click);
            // 
            // buttonTurnLeft
            // 
            this.buttonTurnLeft.Location = new System.Drawing.Point(692, 178);
            this.buttonTurnLeft.Name = "buttonTurnLeft";
            this.buttonTurnLeft.Size = new System.Drawing.Size(75, 55);
            this.buttonTurnLeft.TabIndex = 12;
            this.buttonTurnLeft.Text = "LEFT";
            this.buttonTurnLeft.UseVisualStyleBackColor = true;
            this.buttonTurnLeft.Click += new System.EventHandler(this.buttonTurnLeft_Click);
            // 
            // buttonTurnRight
            // 
            this.buttonTurnRight.Location = new System.Drawing.Point(854, 178);
            this.buttonTurnRight.Name = "buttonTurnRight";
            this.buttonTurnRight.Size = new System.Drawing.Size(75, 55);
            this.buttonTurnRight.TabIndex = 13;
            this.buttonTurnRight.Text = "RIGHT";
            this.buttonTurnRight.UseVisualStyleBackColor = true;
            this.buttonTurnRight.Click += new System.EventHandler(this.buttonTurnRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Position:";
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Location = new System.Drawing.Point(700, 48);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(15, 13);
            this.labelDegree.TabIndex = 16;
            this.labelDegree.Text = "0\'";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(700, 61);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(25, 13);
            this.labelPosition.TabIndex = 17;
            this.labelPosition.Text = "0, 0";
            // 
            // labelDetection
            // 
            this.labelDetection.AutoSize = true;
            this.labelDetection.Location = new System.Drawing.Point(652, 6);
            this.labelDetection.Name = "labelDetection";
            this.labelDetection.Size = new System.Drawing.Size(35, 13);
            this.labelDetection.TabIndex = 12;
            this.labelDetection.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Detected position:";
            // 
            // labelDetectedPosition
            // 
            this.labelDetectedPosition.AutoSize = true;
            this.labelDetectedPosition.Location = new System.Drawing.Point(904, 61);
            this.labelDetectedPosition.Name = "labelDetectedPosition";
            this.labelDetectedPosition.Size = new System.Drawing.Size(25, 13);
            this.labelDetectedPosition.TabIndex = 19;
            this.labelDetectedPosition.Text = "0, 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Detected angle:   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(904, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "NA";
            // 
            // labelDetectionOffset
            // 
            this.labelDetectionOffset.AutoSize = true;
            this.labelDetectionOffset.Location = new System.Drawing.Point(904, 74);
            this.labelDetectionOffset.Name = "labelDetectionOffset";
            this.labelDetectionOffset.Size = new System.Drawing.Size(25, 13);
            this.labelDetectionOffset.TabIndex = 23;
            this.labelDetectionOffset.Text = "0, 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 489);
            this.Controls.Add(this.buttonBrowseBaseImage);
            this.Controls.Add(this.labelBasePath);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grigore detection test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoboBoard)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrig)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGenerated)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonTurnRight;
        private System.Windows.Forms.Button buttonTurnLeft;
        private System.Windows.Forms.Button buttonMoveRv;
        private System.Windows.Forms.Button buttonMoveFw;
        private System.Windows.Forms.Button buttonBrowseRobotImage;
        private System.Windows.Forms.Label labelRobotImagePath;
        private System.Windows.Forms.PictureBox pictureBoxGenerated;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDetection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDetectedPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDetectionOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}

