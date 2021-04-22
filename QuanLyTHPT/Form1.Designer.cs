
namespace QuanLyTHPT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.butDN = new System.Windows.Forms.Button();
            this.butThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(198, 89);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(211, 22);
            this.txtDN.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(198, 153);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(211, 22);
            this.txtMK.TabIndex = 1;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // butDN
            // 
            this.butDN.Location = new System.Drawing.Point(155, 230);
            this.butDN.Name = "butDN";
            this.butDN.Size = new System.Drawing.Size(103, 34);
            this.butDN.TabIndex = 2;
            this.butDN.Text = "Đăng Nhập";
            this.butDN.UseVisualStyleBackColor = true;
            this.butDN.Click += new System.EventHandler(this.butDN_Click);
            // 
            // butThoat
            // 
            this.butThoat.Location = new System.Drawing.Point(334, 230);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(98, 34);
            this.butThoat.TabIndex = 2;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 316);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button butDN;
        private System.Windows.Forms.Button butThoat;
    }
}

