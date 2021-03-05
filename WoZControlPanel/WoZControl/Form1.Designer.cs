namespace WoZControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.cmdResume = new System.Windows.Forms.Button();
            this.cmdIntro = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.btnVADFalse = new System.Windows.Forms.Button();
            this.btnVAD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQi = new System.Windows.Forms.Button();
            this.txtSay = new System.Windows.Forms.TextBox();
            this.btnSay = new System.Windows.Forms.Button();
            this.btncrouch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReengageCounter = new System.Windows.Forms.Label();
            this.btn_kill_all_bhvs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eng_4 = new System.Windows.Forms.Button();
            this.btn_eng_3 = new System.Windows.Forms.Button();
            this.btn_eng_2 = new System.Windows.Forms.Button();
            this.btn_eng_1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtChildName);
            this.groupBox1.Controls.Add(this.cmdResume);
            this.groupBox1.Controls.Add(this.cmdIntro);
            this.groupBox1.Controls.Add(this.cmdPause);
            this.groupBox1.Controls.Add(this.cmdFinish);
            this.groupBox1.Location = new System.Drawing.Point(24, 377);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(688, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interaction Controls";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(492, 33);
            this.btnSync.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(182, 56);
            this.btnSync.TabIndex = 56;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 55;
            this.label2.Text = "Child-Name ; Child-Ppnr ; Robot-Name";
            // 
            // txtChildName
            // 
            this.txtChildName.Location = new System.Drawing.Point(12, 37);
            this.txtChildName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtChildName.Multiline = true;
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(446, 46);
            this.txtChildName.TabIndex = 14;
            // 
            // cmdResume
            // 
            this.cmdResume.Location = new System.Drawing.Point(360, 165);
            this.cmdResume.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(314, 56);
            this.cmdResume.TabIndex = 52;
            this.cmdResume.Text = "Resume";
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // cmdIntro
            // 
            this.cmdIntro.Location = new System.Drawing.Point(12, 98);
            this.cmdIntro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdIntro.Name = "cmdIntro";
            this.cmdIntro.Size = new System.Drawing.Size(314, 56);
            this.cmdIntro.TabIndex = 45;
            this.cmdIntro.Text = "Start Lesson";
            this.cmdIntro.UseVisualStyleBackColor = true;
            this.cmdIntro.Click += new System.EventHandler(this.cmdIntro_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(360, 98);
            this.cmdPause.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(314, 56);
            this.cmdPause.TabIndex = 46;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdFinish
            // 
            this.cmdFinish.Location = new System.Drawing.Point(12, 165);
            this.cmdFinish.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(314, 56);
            this.cmdFinish.TabIndex = 47;
            this.cmdFinish.Text = "Quit Lesson";
            this.cmdFinish.UseVisualStyleBackColor = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // btnVADFalse
            // 
            this.btnVADFalse.Enabled = false;
            this.btnVADFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVADFalse.ForeColor = System.Drawing.Color.Black;
            this.btnVADFalse.Location = new System.Drawing.Point(304, 533);
            this.btnVADFalse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVADFalse.Name = "btnVADFalse";
            this.btnVADFalse.Size = new System.Drawing.Size(212, 50);
            this.btnVADFalse.TabIndex = 53;
            this.btnVADFalse.Text = "No";
            this.btnVADFalse.UseVisualStyleBackColor = true;
            this.btnVADFalse.Click += new System.EventHandler(this.btnVADFalse_Click);
            // 
            // btnVAD
            // 
            this.btnVAD.Enabled = false;
            this.btnVAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAD.ForeColor = System.Drawing.Color.Black;
            this.btnVAD.Location = new System.Drawing.Point(50, 533);
            this.btnVAD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVAD.Name = "btnVAD";
            this.btnVAD.Size = new System.Drawing.Size(212, 50);
            this.btnVAD.TabIndex = 15;
            this.btnVAD.Text = "Yes";
            this.btnVAD.UseVisualStyleBackColor = true;
            this.btnVAD.Click += new System.EventHandler(this.btnVAD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQi);
            this.groupBox2.Controls.Add(this.txtSay);
            this.groupBox2.Controls.Add(this.btnSay);
            this.groupBox2.Controls.Add(this.btncrouch);
            this.groupBox2.Location = new System.Drawing.Point(24, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(688, 185);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Robot Controls";
            // 
            // btnQi
            // 
            this.btnQi.Enabled = false;
            this.btnQi.Location = new System.Drawing.Point(360, 40);
            this.btnQi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQi.Name = "btnQi";
            this.btnQi.Size = new System.Drawing.Size(316, 44);
            this.btnQi.TabIndex = 9;
            this.btnQi.Text = "Motors off";
            this.btnQi.UseVisualStyleBackColor = true;
            this.btnQi.Click += new System.EventHandler(this.btnQi_Click);
            // 
            // txtSay
            // 
            this.txtSay.Location = new System.Drawing.Point(200, 108);
            this.txtSay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSay.Multiline = true;
            this.txtSay.Name = "txtSay";
            this.txtSay.Size = new System.Drawing.Size(474, 46);
            this.txtSay.TabIndex = 8;
            this.txtSay.Text = "wacht even";
            // 
            // btnSay
            // 
            this.btnSay.Enabled = false;
            this.btnSay.Location = new System.Drawing.Point(20, 104);
            this.btnSay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(168, 50);
            this.btnSay.TabIndex = 7;
            this.btnSay.Text = "Robot Speech";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btncrouch
            // 
            this.btncrouch.Enabled = false;
            this.btncrouch.Location = new System.Drawing.Point(18, 40);
            this.btncrouch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btncrouch.Name = "btncrouch";
            this.btncrouch.Size = new System.Drawing.Size(328, 44);
            this.btncrouch.TabIndex = 3;
            this.btncrouch.Text = "Crouch";
            this.btncrouch.UseVisualStyleBackColor = true;
            this.btncrouch.Click += new System.EventHandler(this.btncrouch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Controls.Add(this.btnDisconnect);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(24, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(688, 123);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(104, 54);
            this.txtIP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(168, 31);
            this.txtIP.TabIndex = 15;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(472, 37);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(158, 67);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(296, 37);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(164, 67);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblReengageCounter);
            this.groupBox4.Controls.Add(this.btn_kill_all_bhvs);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_eng_4);
            this.groupBox4.Controls.Add(this.btnVADFalse);
            this.groupBox4.Controls.Add(this.btn_eng_3);
            this.groupBox4.Controls.Add(this.btnVAD);
            this.groupBox4.Controls.Add(this.btn_eng_2);
            this.groupBox4.Controls.Add(this.btn_eng_1);
            this.groupBox4.Location = new System.Drawing.Point(754, 27);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(554, 598);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Engagement Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(160, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 31);
            this.label5.TabIndex = 57;
            this.label5.Text = "Reengage Counter:";
            // 
            // lblReengageCounter
            // 
            this.lblReengageCounter.AutoSize = true;
            this.lblReengageCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReengageCounter.Location = new System.Drawing.Point(428, 31);
            this.lblReengageCounter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReengageCounter.Name = "lblReengageCounter";
            this.lblReengageCounter.Size = new System.Drawing.Size(28, 30);
            this.lblReengageCounter.TabIndex = 56;
            this.lblReengageCounter.Text = "0";
            // 
            // btn_kill_all_bhvs
            // 
            this.btn_kill_all_bhvs.Enabled = false;
            this.btn_kill_all_bhvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kill_all_bhvs.Location = new System.Drawing.Point(50, 396);
            this.btn_kill_all_bhvs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_kill_all_bhvs.Name = "btn_kill_all_bhvs";
            this.btn_kill_all_bhvs.Size = new System.Drawing.Size(466, 62);
            this.btn_kill_all_bhvs.TabIndex = 55;
            this.btn_kill_all_bhvs.Text = "Kill all behaviors";
            this.btn_kill_all_bhvs.UseVisualStyleBackColor = true;
            this.btn_kill_all_bhvs.Click += new System.EventHandler(this.btn_kill_all_bhvs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 475);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Voice Detection";
            // 
            // btn_eng_4
            // 
            this.btn_eng_4.Enabled = false;
            this.btn_eng_4.Location = new System.Drawing.Point(50, 304);
            this.btn_eng_4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_eng_4.Name = "btn_eng_4";
            this.btn_eng_4.Size = new System.Drawing.Size(466, 62);
            this.btn_eng_4.TabIndex = 7;
            this.btn_eng_4.Text = "Distraction high";
            this.btn_eng_4.UseVisualStyleBackColor = true;
            this.btn_eng_4.Click += new System.EventHandler(this.btn_eng_4_Click);
            // 
            // btn_eng_3
            // 
            this.btn_eng_3.Enabled = false;
            this.btn_eng_3.Location = new System.Drawing.Point(50, 231);
            this.btn_eng_3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_eng_3.Name = "btn_eng_3";
            this.btn_eng_3.Size = new System.Drawing.Size(466, 62);
            this.btn_eng_3.TabIndex = 6;
            this.btn_eng_3.Text = "Distraction low";
            this.btn_eng_3.UseVisualStyleBackColor = true;
            this.btn_eng_3.Click += new System.EventHandler(this.btn_eng_3_Click);
            // 
            // btn_eng_2
            // 
            this.btn_eng_2.Enabled = false;
            this.btn_eng_2.Location = new System.Drawing.Point(50, 154);
            this.btn_eng_2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_eng_2.Name = "btn_eng_2";
            this.btn_eng_2.Size = new System.Drawing.Size(466, 65);
            this.btn_eng_2.TabIndex = 5;
            this.btn_eng_2.Text = "Heightened activity";
            this.btn_eng_2.UseVisualStyleBackColor = true;
            this.btn_eng_2.Click += new System.EventHandler(this.btn_eng_2_Click);
            // 
            // btn_eng_1
            // 
            this.btn_eng_1.Enabled = false;
            this.btn_eng_1.Location = new System.Drawing.Point(50, 77);
            this.btn_eng_1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_eng_1.Name = "btn_eng_1";
            this.btn_eng_1.Size = new System.Drawing.Size(466, 65);
            this.btn_eng_1.TabIndex = 4;
            this.btn_eng_1.Text = "Tired";
            this.btn_eng_1.UseVisualStyleBackColor = true;
            this.btn_eng_1.Click += new System.EventHandler(this.btn_eng_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 644);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQi;
        private System.Windows.Forms.TextBox txtSay;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btncrouch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.Button cmdFinish;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Button cmdIntro;
        private System.Windows.Forms.Button btnVAD;
        private System.Windows.Forms.TextBox txtChildName;
        private System.Windows.Forms.Button btnVADFalse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_eng_4;
        private System.Windows.Forms.Button btn_eng_3;
        private System.Windows.Forms.Button btn_eng_2;
        private System.Windows.Forms.Button btn_eng_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kill_all_bhvs;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReengageCounter;
    }
}

