﻿namespace MultiFaceRec
{
    partial class FacePay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacePay));
            this.label10 = new System.Windows.Forms.Label();
            this.lblLoginType = new System.Windows.Forms.Label();
            this.txtSecurePin = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.grbFaceDetect = new System.Windows.Forms.GroupBox();
            this.btnPayAmount = new System.Windows.Forms.Button();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayeeIFSC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPayeeAccountNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPayeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grbPayerDetails = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.grbFaceDetect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbPayerDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(140, 171);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "IFSC Code :";
            // 
            // lblLoginType
            // 
            this.lblLoginType.AutoSize = true;
            this.lblLoginType.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginType.ForeColor = System.Drawing.Color.Gold;
            this.lblLoginType.Location = new System.Drawing.Point(35, 1);
            this.lblLoginType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(412, 54);
            this.lblLoginType.TabIndex = 1;
            this.lblLoginType.Text = "Face Pay Transaction";
            // 
            // txtSecurePin
            // 
            this.txtSecurePin.Location = new System.Drawing.Point(169, 545);
            this.txtSecurePin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecurePin.MaxLength = 10;
            this.txtSecurePin.Name = "txtSecurePin";
            this.txtSecurePin.Size = new System.Drawing.Size(293, 34);
            this.txtSecurePin.TabIndex = 44;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(36, 549);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(119, 28);
            this.label28.TabIndex = 43;
            this.label28.Text = "Secure Pin :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(37, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 119);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(37, 34);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(426, 295);
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // grbFaceDetect
            // 
            this.grbFaceDetect.Controls.Add(this.btnPayAmount);
            this.grbFaceDetect.Controls.Add(this.btnGetDetails);
            this.grbFaceDetect.Controls.Add(this.txtSecurePin);
            this.grbFaceDetect.Controls.Add(this.label28);
            this.grbFaceDetect.Controls.Add(this.button1);
            this.grbFaceDetect.Controls.Add(this.imageBoxFrameGrabber);
            this.grbFaceDetect.Enabled = false;
            this.grbFaceDetect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grbFaceDetect.Location = new System.Drawing.Point(920, 86);
            this.grbFaceDetect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFaceDetect.Name = "grbFaceDetect";
            this.grbFaceDetect.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFaceDetect.Size = new System.Drawing.Size(504, 694);
            this.grbFaceDetect.TabIndex = 24;
            this.grbFaceDetect.TabStop = false;
            this.grbFaceDetect.Text = "Face Detector";
            // 
            // btnPayAmount
            // 
            this.btnPayAmount.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPayAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayAmount.ForeColor = System.Drawing.Color.White;
            this.btnPayAmount.Location = new System.Drawing.Point(37, 617);
            this.btnPayAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayAmount.Name = "btnPayAmount";
            this.btnPayAmount.Size = new System.Drawing.Size(427, 47);
            this.btnPayAmount.TabIndex = 45;
            this.btnPayAmount.Text = "Proceed To Pay";
            this.btnPayAmount.UseVisualStyleBackColor = false;
            this.btnPayAmount.Click += new System.EventHandler(this.btnPayAmount_Click);
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetails.ForeColor = System.Drawing.Color.White;
            this.btnGetDetails.Location = new System.Drawing.Point(37, 479);
            this.btnGetDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(427, 47);
            this.btnGetDetails.TabIndex = 23;
            this.btnGetDetails.Text = "Validate User";
            this.btnGetDetails.UseVisualStyleBackColor = false;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(140, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 28);
            this.label9.TabIndex = 45;
            this.label9.Text = "IFSC Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(105, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Enter Amount :";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayAmount.Location = new System.Drawing.Point(273, 219);
            this.txtPayAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(461, 34);
            this.txtPayAmount.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(141, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "IFSC Code :";
            this.label4.Visible = false;
            // 
            // txtPayeeIFSC
            // 
            this.txtPayeeIFSC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayeeIFSC.Location = new System.Drawing.Point(273, 162);
            this.txtPayeeIFSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayeeIFSC.Name = "txtPayeeIFSC";
            this.txtPayeeIFSC.Size = new System.Drawing.Size(461, 34);
            this.txtPayeeIFSC.TabIndex = 17;
            this.txtPayeeIFSC.Text = "SILL000111";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(120, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Account No. :";
            // 
            // txtPayeeAccountNo
            // 
            this.txtPayeeAccountNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayeeAccountNo.Location = new System.Drawing.Point(273, 102);
            this.txtPayeeAccountNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayeeAccountNo.Name = "txtPayeeAccountNo";
            this.txtPayeeAccountNo.Size = new System.Drawing.Size(461, 34);
            this.txtPayeeAccountNo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(120, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Payee Name :";
            // 
            // txtPayeeName
            // 
            this.txtPayeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPayeeName.Location = new System.Drawing.Point(273, 47);
            this.txtPayeeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayeeName.Name = "txtPayeeName";
            this.txtPayeeName.Size = new System.Drawing.Size(461, 34);
            this.txtPayeeName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(141, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "IFSC Code :";
            this.label3.Visible = false;
            // 
            // txtIFSC
            // 
            this.txtIFSC.Enabled = false;
            this.txtIFSC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtIFSC.Location = new System.Drawing.Point(273, 162);
            this.txtIFSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(461, 34);
            this.txtIFSC.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(120, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account No. :";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAccountNumber.Location = new System.Drawing.Point(273, 102);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(461, 34);
            this.txtAccountNumber.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Holder Name :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(273, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 34);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPayAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPayeeIFSC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPayeeAccountNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPayeeName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(93, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(789, 386);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payee Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(552, 283);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 47);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(273, 283);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(184, 47);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grbPayerDetails
            // 
            this.grbPayerDetails.Controls.Add(this.label9);
            this.grbPayerDetails.Controls.Add(this.label3);
            this.grbPayerDetails.Controls.Add(this.txtIFSC);
            this.grbPayerDetails.Controls.Add(this.label2);
            this.grbPayerDetails.Controls.Add(this.txtAccountNumber);
            this.grbPayerDetails.Controls.Add(this.label1);
            this.grbPayerDetails.Controls.Add(this.textBox1);
            this.grbPayerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPayerDetails.Location = new System.Drawing.Point(93, 514);
            this.grbPayerDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbPayerDetails.Name = "grbPayerDetails";
            this.grbPayerDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbPayerDetails.Size = new System.Drawing.Size(789, 266);
            this.grbPayerDetails.TabIndex = 22;
            this.grbPayerDetails.TabStop = false;
            this.grbPayerDetails.Text = "Payer Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblLoginType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1692, 64);
            this.panel1.TabIndex = 21;
            // 
            // FacePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1692, 828);
            this.Controls.Add(this.grbFaceDetect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbPayerDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacePay";
            this.Text = "FacePay";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.grbFaceDetect.ResumeLayout(false);
            this.grbFaceDetect.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbPayerDetails.ResumeLayout(false);
            this.grbPayerDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLoginType;
        private System.Windows.Forms.TextBox txtSecurePin;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.GroupBox grbFaceDetect;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayeeIFSC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayeeAccountNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPayeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbPayerDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPayAmount;
    }
}