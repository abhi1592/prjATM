namespace prjFinalProject
{
    partial class frmGab
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCardNumb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnNextPin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.GroupBox();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.btnNextAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDollar2 = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.rdbConsult = new System.Windows.Forms.RadioButton();
            this.rdbWithdraw = new System.Windows.Forms.RadioButton();
            this.rdbDeposit = new System.Windows.Forms.RadioButton();
            this.btnNextTrans = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblConsult = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtType.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYALE BANK ATM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.txtCardNumb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(544, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "READING OF CARD";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(405, 120);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "NEXT>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtCardNumb
            // 
            this.txtCardNumb.Location = new System.Drawing.Point(252, 48);
            this.txtCardNumb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNumb.Name = "txtCardNumb";
            this.txtCardNumb.Size = new System.Drawing.Size(229, 28);
            this.txtCardNumb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "CARD NUMBER:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblClient);
            this.groupBox2.Controls.Add(this.btnNextPin);
            this.groupBox2.Controls.Add(this.txtPin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(544, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PIN VALIDATION";
            // 
            // lblClient
            // 
            this.lblClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClient.ForeColor = System.Drawing.Color.Red;
            this.lblClient.Location = new System.Drawing.Point(17, 41);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(288, 31);
            this.lblClient.TabIndex = 3;
            // 
            // btnNextPin
            // 
            this.btnNextPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPin.Location = new System.Drawing.Point(405, 150);
            this.btnNextPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextPin.Name = "btnNextPin";
            this.btnNextPin.Size = new System.Drawing.Size(133, 34);
            this.btnNextPin.TabIndex = 2;
            this.btnNextPin.Text = "NEXT>>";
            this.btnNextPin.UseVisualStyleBackColor = true;
            this.btnNextPin.Click += new System.EventHandler(this.btnNextPin_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(252, 85);
            this.txtPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(229, 28);
            this.txtPin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENTER PIN:";
            // 
            // txtType
            // 
            this.txtType.Controls.Add(this.cBoxType);
            this.txtType.Controls.Add(this.btnNextAcc);
            this.txtType.Controls.Add(this.label5);
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(14, 464);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Size = new System.Drawing.Size(544, 161);
            this.txtType.TabIndex = 3;
            this.txtType.TabStop = false;
            this.txtType.Text = "ACCOUNT TYPES";
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Location = new System.Drawing.Point(252, 49);
            this.cBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(229, 30);
            this.cBoxType.TabIndex = 3;
            // 
            // btnNextAcc
            // 
            this.btnNextAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAcc.Location = new System.Drawing.Point(405, 120);
            this.btnNextAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextAcc.Name = "btnNextAcc";
            this.btnNextAcc.Size = new System.Drawing.Size(133, 34);
            this.btnNextAcc.TabIndex = 2;
            this.btnNextAcc.Text = "NEXT>>";
            this.btnNextAcc.UseVisualStyleBackColor = true;
            this.btnNextAcc.Click += new System.EventHandler(this.btnNextAcc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "SELECT TYPE:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDollar2);
            this.groupBox4.Controls.Add(this.lblDollar);
            this.groupBox4.Controls.Add(this.txtWithdraw);
            this.groupBox4.Controls.Add(this.rdbConsult);
            this.groupBox4.Controls.Add(this.rdbWithdraw);
            this.groupBox4.Controls.Add(this.rdbDeposit);
            this.groupBox4.Controls.Add(this.btnNextTrans);
            this.groupBox4.Controls.Add(this.txtDeposit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 644);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(544, 199);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TRANSACTION TYPES";
            // 
            // lblDollar2
            // 
            this.lblDollar2.AutoSize = true;
            this.lblDollar2.Location = new System.Drawing.Point(458, 82);
            this.lblDollar2.Name = "lblDollar2";
            this.lblDollar2.Size = new System.Drawing.Size(21, 24);
            this.lblDollar2.TabIndex = 8;
            this.lblDollar2.Text = "$";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(458, 41);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(21, 24);
            this.lblDollar.TabIndex = 7;
            this.lblDollar.Text = "$";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(252, 79);
            this.txtWithdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(199, 28);
            this.txtWithdraw.TabIndex = 6;
            this.txtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWithdraw_KeyPress);
            // 
            // rdbConsult
            // 
            this.rdbConsult.AutoSize = true;
            this.rdbConsult.Location = new System.Drawing.Point(17, 122);
            this.rdbConsult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbConsult.Name = "rdbConsult";
            this.rdbConsult.Size = new System.Drawing.Size(127, 28);
            this.rdbConsult.TabIndex = 5;
            this.rdbConsult.TabStop = true;
            this.rdbConsult.Text = "CONSULT";
            this.rdbConsult.UseVisualStyleBackColor = true;
            this.rdbConsult.CheckedChanged += new System.EventHandler(this.rdbConsult_CheckedChanged);
            // 
            // rdbWithdraw
            // 
            this.rdbWithdraw.AutoSize = true;
            this.rdbWithdraw.Location = new System.Drawing.Point(17, 79);
            this.rdbWithdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbWithdraw.Name = "rdbWithdraw";
            this.rdbWithdraw.Size = new System.Drawing.Size(144, 28);
            this.rdbWithdraw.TabIndex = 4;
            this.rdbWithdraw.TabStop = true;
            this.rdbWithdraw.Text = "WITHDRAW";
            this.rdbWithdraw.UseVisualStyleBackColor = true;
            this.rdbWithdraw.CheckedChanged += new System.EventHandler(this.rdbWithdraw_CheckedChanged);
            // 
            // rdbDeposit
            // 
            this.rdbDeposit.AutoSize = true;
            this.rdbDeposit.Location = new System.Drawing.Point(17, 35);
            this.rdbDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDeposit.Name = "rdbDeposit";
            this.rdbDeposit.Size = new System.Drawing.Size(119, 28);
            this.rdbDeposit.TabIndex = 3;
            this.rdbDeposit.TabStop = true;
            this.rdbDeposit.Text = "DEPOSIT";
            this.rdbDeposit.UseVisualStyleBackColor = true;
            this.rdbDeposit.CheckedChanged += new System.EventHandler(this.rdbDeposit_CheckedChanged);
            // 
            // btnNextTrans
            // 
            this.btnNextTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTrans.Location = new System.Drawing.Point(405, 158);
            this.btnNextTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextTrans.Name = "btnNextTrans";
            this.btnNextTrans.Size = new System.Drawing.Size(133, 34);
            this.btnNextTrans.TabIndex = 2;
            this.btnNextTrans.Text = "NEXT>>";
            this.btnNextTrans.UseVisualStyleBackColor = true;
            this.btnNextTrans.Click += new System.EventHandler(this.btnNextTrans_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(252, 36);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(199, 28);
            this.txtDeposit.TabIndex = 1;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblConsult);
            this.groupBox5.Controls.Add(this.btnTerminate);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 850);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(544, 196);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ACCOUNT INFORMATIONS";
            // 
            // lblConsult
            // 
            this.lblConsult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblConsult.Location = new System.Drawing.Point(7, 30);
            this.lblConsult.Name = "lblConsult";
            this.lblConsult.Size = new System.Drawing.Size(386, 159);
            this.lblConsult.TabIndex = 3;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminate.Location = new System.Drawing.Point(405, 155);
            this.btnTerminate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(133, 34);
            this.btnTerminate.TabIndex = 2;
            this.btnTerminate.Text = "TERMINATE";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // frmGab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 1042);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGab";
            this.Text = "frmGab";
            this.Load += new System.EventHandler(this.frmGab_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txtType.ResumeLayout(false);
            this.txtType.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtCardNumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnNextPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox txtType;
        private System.Windows.Forms.Button btnNextAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDollar2;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.RadioButton rdbConsult;
        private System.Windows.Forms.RadioButton rdbWithdraw;
        private System.Windows.Forms.RadioButton rdbDeposit;
        private System.Windows.Forms.Button btnNextTrans;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblConsult;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.ComboBox cBoxType;
    }
}