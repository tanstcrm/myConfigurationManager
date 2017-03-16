namespace FpgaCongifurationManager
{
    partial class FpgaStatusComponent
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddrTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddrCheckResultLbl = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.send4SettingsBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CoinnSendValLbl = new System.Windows.Forms.Label();
            this.coinnCurValLbl = new System.Windows.Forms.Label();
            this.setCoinnBtn = new System.Windows.Forms.Button();
            this.coinnSendTbx = new System.Windows.Forms.TextBox();
            this.getCoinnBtn = new System.Windows.Forms.Button();
            this.coinnCurLbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CoinwSendValLbl = new System.Windows.Forms.Label();
            this.CoinwCurValLbl = new System.Windows.Forms.Label();
            this.setCoinwBtn = new System.Windows.Forms.Button();
            this.CoinwSendTbx = new System.Windows.Forms.TextBox();
            this.getCoinwBtn = new System.Windows.Forms.Button();
            this.CoinwCurLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deadtSendValLbl = new System.Windows.Forms.Label();
            this.deadtCurValLbl = new System.Windows.Forms.Label();
            this.setDeadtBtn = new System.Windows.Forms.Button();
            this.deadtSendTbx = new System.Windows.Forms.TextBox();
            this.getDeadtBtn = new System.Windows.Forms.Button();
            this.deadtCurLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.twSendValLbl = new System.Windows.Forms.Label();
            this.twCurValLbl = new System.Windows.Forms.Label();
            this.setTwBtn = new System.Windows.Forms.Button();
            this.twSendTbx = new System.Windows.Forms.TextBox();
            this.getTwBtn = new System.Windows.Forms.Button();
            this.twCurLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dac2ValueLbl = new System.Windows.Forms.Label();
            this.dac1ValueLbl = new System.Windows.Forms.Label();
            this.dac0ValueLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dacApplyAllBtn = new System.Windows.Forms.Button();
            this.dacApplyBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dac3Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dac2Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dac1Tbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dac0Tbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PadNumList = new System.Windows.Forms.ComboBox();
            this.dac3ValueLbl = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipAddrTbx
            // 
            this.ipAddrTbx.Location = new System.Drawing.Point(29, 44);
            this.ipAddrTbx.Name = "ipAddrTbx";
            this.ipAddrTbx.Size = new System.Drawing.Size(270, 25);
            this.ipAddrTbx.TabIndex = 0;
            this.ipAddrTbx.TextChanged += new System.EventHandler(this.ipAddrTbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // ipAddrCheckResultLbl
            // 
            this.ipAddrCheckResultLbl.AutoSize = true;
            this.ipAddrCheckResultLbl.Location = new System.Drawing.Point(329, 47);
            this.ipAddrCheckResultLbl.Name = "ipAddrCheckResultLbl";
            this.ipAddrCheckResultLbl.Size = new System.Drawing.Size(35, 18);
            this.ipAddrCheckResultLbl.TabIndex = 2;
            this.ipAddrCheckResultLbl.Text = "---";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.send4SettingsBtn);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Location = new System.Drawing.Point(29, 290);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(529, 361);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // send4SettingsBtn
            // 
            this.send4SettingsBtn.Location = new System.Drawing.Point(414, 311);
            this.send4SettingsBtn.Name = "send4SettingsBtn";
            this.send4SettingsBtn.Size = new System.Drawing.Size(101, 44);
            this.send4SettingsBtn.TabIndex = 12;
            this.send4SettingsBtn.Text = "GetAll";
            this.send4SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CoinnSendValLbl);
            this.groupBox5.Controls.Add(this.coinnCurValLbl);
            this.groupBox5.Controls.Add(this.setCoinnBtn);
            this.groupBox5.Controls.Add(this.coinnSendTbx);
            this.groupBox5.Controls.Add(this.getCoinnBtn);
            this.groupBox5.Controls.Add(this.coinnCurLbl);
            this.groupBox5.Location = new System.Drawing.Point(278, 170);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 131);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CoincidenceNum";
            // 
            // CoinnSendValLbl
            // 
            this.CoinnSendValLbl.AutoSize = true;
            this.CoinnSendValLbl.Location = new System.Drawing.Point(86, 83);
            this.CoinnSendValLbl.Name = "CoinnSendValLbl";
            this.CoinnSendValLbl.Size = new System.Drawing.Size(61, 18);
            this.CoinnSendValLbl.TabIndex = 5;
            this.CoinnSendValLbl.Text = "label13";
            // 
            // coinnCurValLbl
            // 
            this.coinnCurValLbl.AutoSize = true;
            this.coinnCurValLbl.Location = new System.Drawing.Point(153, 35);
            this.coinnCurValLbl.Name = "coinnCurValLbl";
            this.coinnCurValLbl.Size = new System.Drawing.Size(40, 18);
            this.coinnCurValLbl.TabIndex = 4;
            this.coinnCurValLbl.Text = "N/A";
            // 
            // setCoinnBtn
            // 
            this.setCoinnBtn.Location = new System.Drawing.Point(159, 77);
            this.setCoinnBtn.Name = "setCoinnBtn";
            this.setCoinnBtn.Size = new System.Drawing.Size(65, 30);
            this.setCoinnBtn.TabIndex = 3;
            this.setCoinnBtn.Text = "Set";
            this.setCoinnBtn.UseVisualStyleBackColor = true;
            // 
            // coinnSendTbx
            // 
            this.coinnSendTbx.Location = new System.Drawing.Point(15, 80);
            this.coinnSendTbx.Name = "coinnSendTbx";
            this.coinnSendTbx.Size = new System.Drawing.Size(65, 25);
            this.coinnSendTbx.TabIndex = 2;
            // 
            // getCoinnBtn
            // 
            this.getCoinnBtn.Location = new System.Drawing.Point(15, 31);
            this.getCoinnBtn.Name = "getCoinnBtn";
            this.getCoinnBtn.Size = new System.Drawing.Size(61, 27);
            this.getCoinnBtn.TabIndex = 1;
            this.getCoinnBtn.Text = "Get";
            this.getCoinnBtn.UseVisualStyleBackColor = true;
            // 
            // coinnCurLbl
            // 
            this.coinnCurLbl.AutoSize = true;
            this.coinnCurLbl.Location = new System.Drawing.Point(86, 35);
            this.coinnCurLbl.Name = "coinnCurLbl";
            this.coinnCurLbl.Size = new System.Drawing.Size(40, 18);
            this.coinnCurLbl.TabIndex = 0;
            this.coinnCurLbl.Text = "N/A";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CoinwSendValLbl);
            this.groupBox4.Controls.Add(this.CoinwCurValLbl);
            this.groupBox4.Controls.Add(this.setCoinwBtn);
            this.groupBox4.Controls.Add(this.CoinwSendTbx);
            this.groupBox4.Controls.Add(this.getCoinwBtn);
            this.groupBox4.Controls.Add(this.CoinwCurLbl);
            this.groupBox4.Location = new System.Drawing.Point(16, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 131);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CoincidenceWidth";
            // 
            // CoinwSendValLbl
            // 
            this.CoinwSendValLbl.AutoSize = true;
            this.CoinwSendValLbl.Location = new System.Drawing.Point(86, 83);
            this.CoinwSendValLbl.Name = "CoinwSendValLbl";
            this.CoinwSendValLbl.Size = new System.Drawing.Size(61, 18);
            this.CoinwSendValLbl.TabIndex = 5;
            this.CoinwSendValLbl.Text = "label13";
            // 
            // CoinwCurValLbl
            // 
            this.CoinwCurValLbl.AutoSize = true;
            this.CoinwCurValLbl.Location = new System.Drawing.Point(153, 35);
            this.CoinwCurValLbl.Name = "CoinwCurValLbl";
            this.CoinwCurValLbl.Size = new System.Drawing.Size(40, 18);
            this.CoinwCurValLbl.TabIndex = 4;
            this.CoinwCurValLbl.Text = "N/A";
            // 
            // setCoinwBtn
            // 
            this.setCoinwBtn.Location = new System.Drawing.Point(159, 77);
            this.setCoinwBtn.Name = "setCoinwBtn";
            this.setCoinwBtn.Size = new System.Drawing.Size(65, 30);
            this.setCoinwBtn.TabIndex = 3;
            this.setCoinwBtn.Text = "Set";
            this.setCoinwBtn.UseVisualStyleBackColor = true;
            // 
            // CoinwSendTbx
            // 
            this.CoinwSendTbx.Location = new System.Drawing.Point(15, 80);
            this.CoinwSendTbx.Name = "CoinwSendTbx";
            this.CoinwSendTbx.Size = new System.Drawing.Size(65, 25);
            this.CoinwSendTbx.TabIndex = 2;
            // 
            // getCoinwBtn
            // 
            this.getCoinwBtn.Location = new System.Drawing.Point(15, 31);
            this.getCoinwBtn.Name = "getCoinwBtn";
            this.getCoinwBtn.Size = new System.Drawing.Size(61, 27);
            this.getCoinwBtn.TabIndex = 1;
            this.getCoinwBtn.Text = "Get";
            this.getCoinwBtn.UseVisualStyleBackColor = true;
            // 
            // CoinwCurLbl
            // 
            this.CoinwCurLbl.AutoSize = true;
            this.CoinwCurLbl.Location = new System.Drawing.Point(86, 35);
            this.CoinwCurLbl.Name = "CoinwCurLbl";
            this.CoinwCurLbl.Size = new System.Drawing.Size(40, 18);
            this.CoinwCurLbl.TabIndex = 0;
            this.CoinwCurLbl.Text = "N/A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deadtSendValLbl);
            this.groupBox3.Controls.Add(this.deadtCurValLbl);
            this.groupBox3.Controls.Add(this.setDeadtBtn);
            this.groupBox3.Controls.Add(this.deadtSendTbx);
            this.groupBox3.Controls.Add(this.getDeadtBtn);
            this.groupBox3.Controls.Add(this.deadtCurLbl);
            this.groupBox3.Location = new System.Drawing.Point(278, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 131);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DeadTimeWidth";
            // 
            // deadtSendValLbl
            // 
            this.deadtSendValLbl.AutoSize = true;
            this.deadtSendValLbl.Location = new System.Drawing.Point(86, 83);
            this.deadtSendValLbl.Name = "deadtSendValLbl";
            this.deadtSendValLbl.Size = new System.Drawing.Size(61, 18);
            this.deadtSendValLbl.TabIndex = 5;
            this.deadtSendValLbl.Text = "label13";
            // 
            // deadtCurValLbl
            // 
            this.deadtCurValLbl.AutoSize = true;
            this.deadtCurValLbl.Location = new System.Drawing.Point(153, 35);
            this.deadtCurValLbl.Name = "deadtCurValLbl";
            this.deadtCurValLbl.Size = new System.Drawing.Size(40, 18);
            this.deadtCurValLbl.TabIndex = 4;
            this.deadtCurValLbl.Text = "N/A";
            // 
            // setDeadtBtn
            // 
            this.setDeadtBtn.Location = new System.Drawing.Point(159, 77);
            this.setDeadtBtn.Name = "setDeadtBtn";
            this.setDeadtBtn.Size = new System.Drawing.Size(65, 30);
            this.setDeadtBtn.TabIndex = 3;
            this.setDeadtBtn.Text = "Set";
            this.setDeadtBtn.UseVisualStyleBackColor = true;
            // 
            // deadtSendTbx
            // 
            this.deadtSendTbx.Location = new System.Drawing.Point(15, 80);
            this.deadtSendTbx.Name = "deadtSendTbx";
            this.deadtSendTbx.Size = new System.Drawing.Size(65, 25);
            this.deadtSendTbx.TabIndex = 2;
            // 
            // getDeadtBtn
            // 
            this.getDeadtBtn.Location = new System.Drawing.Point(15, 31);
            this.getDeadtBtn.Name = "getDeadtBtn";
            this.getDeadtBtn.Size = new System.Drawing.Size(61, 27);
            this.getDeadtBtn.TabIndex = 1;
            this.getDeadtBtn.Text = "Get";
            this.getDeadtBtn.UseVisualStyleBackColor = true;
            // 
            // deadtCurLbl
            // 
            this.deadtCurLbl.AutoSize = true;
            this.deadtCurLbl.Location = new System.Drawing.Point(86, 35);
            this.deadtCurLbl.Name = "deadtCurLbl";
            this.deadtCurLbl.Size = new System.Drawing.Size(40, 18);
            this.deadtCurLbl.TabIndex = 0;
            this.deadtCurLbl.Text = "N/A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.twSendValLbl);
            this.groupBox2.Controls.Add(this.twCurValLbl);
            this.groupBox2.Controls.Add(this.setTwBtn);
            this.groupBox2.Controls.Add(this.twSendTbx);
            this.groupBox2.Controls.Add(this.getTwBtn);
            this.groupBox2.Controls.Add(this.twCurLbl);
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SamplingWidth";
            // 
            // twSendValLbl
            // 
            this.twSendValLbl.AutoSize = true;
            this.twSendValLbl.Location = new System.Drawing.Point(86, 83);
            this.twSendValLbl.Name = "twSendValLbl";
            this.twSendValLbl.Size = new System.Drawing.Size(61, 18);
            this.twSendValLbl.TabIndex = 5;
            this.twSendValLbl.Text = "label13";
            // 
            // twCurValLbl
            // 
            this.twCurValLbl.AutoSize = true;
            this.twCurValLbl.Location = new System.Drawing.Point(153, 35);
            this.twCurValLbl.Name = "twCurValLbl";
            this.twCurValLbl.Size = new System.Drawing.Size(40, 18);
            this.twCurValLbl.TabIndex = 4;
            this.twCurValLbl.Text = "N/A";
            // 
            // setTwBtn
            // 
            this.setTwBtn.Location = new System.Drawing.Point(159, 77);
            this.setTwBtn.Name = "setTwBtn";
            this.setTwBtn.Size = new System.Drawing.Size(65, 30);
            this.setTwBtn.TabIndex = 3;
            this.setTwBtn.Text = "Set";
            this.setTwBtn.UseVisualStyleBackColor = true;
            // 
            // twSendTbx
            // 
            this.twSendTbx.Location = new System.Drawing.Point(15, 80);
            this.twSendTbx.Name = "twSendTbx";
            this.twSendTbx.Size = new System.Drawing.Size(65, 25);
            this.twSendTbx.TabIndex = 2;
            // 
            // getTwBtn
            // 
            this.getTwBtn.Location = new System.Drawing.Point(15, 31);
            this.getTwBtn.Name = "getTwBtn";
            this.getTwBtn.Size = new System.Drawing.Size(61, 27);
            this.getTwBtn.TabIndex = 1;
            this.getTwBtn.Text = "Get";
            this.getTwBtn.UseVisualStyleBackColor = true;
            // 
            // twCurLbl
            // 
            this.twCurLbl.AutoSize = true;
            this.twCurLbl.Location = new System.Drawing.Point(86, 35);
            this.twCurLbl.Name = "twCurLbl";
            this.twCurLbl.Size = new System.Drawing.Size(40, 18);
            this.twCurLbl.TabIndex = 0;
            this.twCurLbl.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dac3ValueLbl);
            this.groupBox1.Controls.Add(this.dac2ValueLbl);
            this.groupBox1.Controls.Add(this.dac1ValueLbl);
            this.groupBox1.Controls.Add(this.dac0ValueLbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dacApplyAllBtn);
            this.groupBox1.Controls.Add(this.dacApplyBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dac3Tbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dac2Tbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dac1Tbx);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dac0Tbx);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PadNumList);
            this.groupBox1.Location = new System.Drawing.Point(29, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DAC Setting";
            // 
            // dac2ValueLbl
            // 
            this.dac2ValueLbl.AutoSize = true;
            this.dac2ValueLbl.Location = new System.Drawing.Point(266, 121);
            this.dac2ValueLbl.Name = "dac2ValueLbl";
            this.dac2ValueLbl.Size = new System.Drawing.Size(45, 18);
            this.dac2ValueLbl.TabIndex = 26;
            this.dac2ValueLbl.Text = "VthB";
            // 
            // dac1ValueLbl
            // 
            this.dac1ValueLbl.AutoSize = true;
            this.dac1ValueLbl.Location = new System.Drawing.Point(151, 121);
            this.dac1ValueLbl.Name = "dac1ValueLbl";
            this.dac1ValueLbl.Size = new System.Drawing.Size(45, 18);
            this.dac1ValueLbl.TabIndex = 24;
            this.dac1ValueLbl.Text = "VthA";
            // 
            // dac0ValueLbl
            // 
            this.dac0ValueLbl.AutoSize = true;
            this.dac0ValueLbl.Location = new System.Drawing.Point(36, 121);
            this.dac0ValueLbl.Name = "dac0ValueLbl";
            this.dac0ValueLbl.Size = new System.Drawing.Size(31, 18);
            this.dac0ValueLbl.TabIndex = 22;
            this.dac0ValueLbl.Text = "HV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dacApplyAllBtn
            // 
            this.dacApplyAllBtn.Location = new System.Drawing.Point(652, 63);
            this.dacApplyAllBtn.Name = "dacApplyAllBtn";
            this.dacApplyAllBtn.Size = new System.Drawing.Size(111, 41);
            this.dacApplyAllBtn.TabIndex = 16;
            this.dacApplyAllBtn.Text = "Apply ALL";
            this.dacApplyAllBtn.UseVisualStyleBackColor = true;
            // 
            // dacApplyBtn
            // 
            this.dacApplyBtn.Location = new System.Drawing.Point(505, 63);
            this.dacApplyBtn.Name = "dacApplyBtn";
            this.dacApplyBtn.Size = new System.Drawing.Size(111, 41);
            this.dacApplyBtn.TabIndex = 15;
            this.dacApplyBtn.Text = "Apply";
            this.dacApplyBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "reserved";
            // 
            // dac3Tbx
            // 
            this.dac3Tbx.Location = new System.Drawing.Point(382, 84);
            this.dac3Tbx.Name = "dac3Tbx";
            this.dac3Tbx.Size = new System.Drawing.Size(76, 25);
            this.dac3Tbx.TabIndex = 13;
            this.dac3Tbx.TextChanged += new System.EventHandler(this.dac3Tbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "VthB";
            // 
            // dac2Tbx
            // 
            this.dac2Tbx.Location = new System.Drawing.Point(269, 84);
            this.dac2Tbx.Name = "dac2Tbx";
            this.dac2Tbx.Size = new System.Drawing.Size(76, 25);
            this.dac2Tbx.TabIndex = 11;
            this.dac2Tbx.TextChanged += new System.EventHandler(this.dac2Tbx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "VthA";
            // 
            // dac1Tbx
            // 
            this.dac1Tbx.Location = new System.Drawing.Point(154, 84);
            this.dac1Tbx.Name = "dac1Tbx";
            this.dac1Tbx.Size = new System.Drawing.Size(76, 25);
            this.dac1Tbx.TabIndex = 9;
            this.dac1Tbx.TextChanged += new System.EventHandler(this.dac1Tbx_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "HV";
            // 
            // dac0Tbx
            // 
            this.dac0Tbx.Location = new System.Drawing.Point(39, 84);
            this.dac0Tbx.Name = "dac0Tbx";
            this.dac0Tbx.Size = new System.Drawing.Size(76, 25);
            this.dac0Tbx.TabIndex = 7;
            this.dac0Tbx.TextChanged += new System.EventHandler(this.dac0Tbx_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "PAD Num";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PadNumList
            // 
            this.PadNumList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PadNumList.FormattingEnabled = true;
            this.PadNumList.Location = new System.Drawing.Point(109, 25);
            this.PadNumList.Name = "PadNumList";
            this.PadNumList.Size = new System.Drawing.Size(121, 26);
            this.PadNumList.TabIndex = 7;
            // 
            // dac3ValueLbl
            // 
            this.dac3ValueLbl.AutoSize = true;
            this.dac3ValueLbl.Location = new System.Drawing.Point(380, 121);
            this.dac3ValueLbl.Name = "dac3ValueLbl";
            this.dac3ValueLbl.Size = new System.Drawing.Size(0, 18);
            this.dac3ValueLbl.TabIndex = 27;
            // 
            // FpgaStatusComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.ipAddrCheckResultLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddrTbx);
            this.Name = "FpgaStatusComponent";
            this.Size = new System.Drawing.Size(1141, 709);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAddrTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ipAddrCheckResultLbl;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button send4SettingsBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label CoinnSendValLbl;
        private System.Windows.Forms.Label coinnCurValLbl;
        private System.Windows.Forms.Button setCoinnBtn;
        private System.Windows.Forms.TextBox coinnSendTbx;
        private System.Windows.Forms.Button getCoinnBtn;
        private System.Windows.Forms.Label coinnCurLbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label CoinwSendValLbl;
        private System.Windows.Forms.Label CoinwCurValLbl;
        private System.Windows.Forms.Button setCoinwBtn;
        private System.Windows.Forms.TextBox CoinwSendTbx;
        private System.Windows.Forms.Button getCoinwBtn;
        private System.Windows.Forms.Label CoinwCurLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label deadtSendValLbl;
        private System.Windows.Forms.Label deadtCurValLbl;
        private System.Windows.Forms.Button setDeadtBtn;
        private System.Windows.Forms.TextBox deadtSendTbx;
        private System.Windows.Forms.Button getDeadtBtn;
        private System.Windows.Forms.Label deadtCurLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label twSendValLbl;
        private System.Windows.Forms.Label twCurValLbl;
        private System.Windows.Forms.Button setTwBtn;
        private System.Windows.Forms.TextBox twSendTbx;
        private System.Windows.Forms.Button getTwBtn;
        private System.Windows.Forms.Label twCurLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dac2ValueLbl;
        private System.Windows.Forms.Label dac1ValueLbl;
        private System.Windows.Forms.Label dac0ValueLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dacApplyAllBtn;
        private System.Windows.Forms.Button dacApplyBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dac3Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dac2Tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dac1Tbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dac0Tbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PadNumList;
        private System.Windows.Forms.Label dac3ValueLbl;
    }
}
