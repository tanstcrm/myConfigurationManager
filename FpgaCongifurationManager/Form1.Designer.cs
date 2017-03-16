namespace FpgaCongifurationManager
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.fpgaListBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fpgaStatusComponent1 = new FpgaCongifurationManager.FpgaStatusComponent();
            this.SuspendLayout();
            // 
            // fpgaListBox
            // 
            this.fpgaListBox.FormattingEnabled = true;
            this.fpgaListBox.Location = new System.Drawing.Point(45, 33);
            this.fpgaListBox.Name = "fpgaListBox";
            this.fpgaListBox.Size = new System.Drawing.Size(316, 26);
            this.fpgaListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fpgaStatusComponent1
            // 
            this.fpgaStatusComponent1.Location = new System.Drawing.Point(69, 212);
            this.fpgaStatusComponent1.Name = "fpgaStatusComponent1";
            this.fpgaStatusComponent1.Size = new System.Drawing.Size(1105, 420);
            this.fpgaStatusComponent1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 765);
            this.Controls.Add(this.fpgaStatusComponent1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fpgaListBox);
            this.Name = "Form1";
            this.Text = "FPGA Configuration Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox fpgaListBox;
        private System.Windows.Forms.Button button1;
        private FpgaStatusComponent fpgaStatusComponent1;
    }
}

