
namespace QuanLyTHPT
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMGV = new System.Windows.Forms.TextBox();
            this.dsGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNSGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // txtMGV
            // 
            this.txtMGV.Location = new System.Drawing.Point(185, 50);
            this.txtMGV.Multiline = true;
            this.txtMGV.Name = "txtMGV";
            this.txtMGV.Size = new System.Drawing.Size(165, 34);
            this.txtMGV.TabIndex = 2;
            // 
            // dsGV
            // 
            this.dsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsGV.Location = new System.Drawing.Point(128, 335);
            this.dsGV.Name = "dsGV";
            this.dsGV.RowHeadersWidth = 51;
            this.dsGV.RowTemplate.Height = 24;
            this.dsGV.Size = new System.Drawing.Size(726, 150);
            this.dsGV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // txtTGV
            // 
            this.txtTGV.Location = new System.Drawing.Point(185, 103);
            this.txtTGV.Multiline = true;
            this.txtTGV.Name = "txtTGV";
            this.txtTGV.Size = new System.Drawing.Size(165, 34);
            this.txtTGV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtNSGV
            // 
            this.txtNSGV.Location = new System.Drawing.Point(185, 159);
            this.txtNSGV.Multiline = true;
            this.txtNSGV.Name = "txtNSGV";
            this.txtNSGV.Size = new System.Drawing.Size(165, 34);
            this.txtNSGV.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính";
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(185, 225);
            this.txtGT.Multiline = true;
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(165, 34);
            this.txtGT.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butTim
            // 
            this.butTim.Location = new System.Drawing.Point(551, 282);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(75, 23);
            this.butTim.TabIndex = 0;
            this.butTim.Text = "Tìm kiếm";
            this.butTim.UseVisualStyleBackColor = true;
            this.butTim.Click += new System.EventHandler(this.butTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(509, 225);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(165, 34);
            this.txtTim.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập mã cần tìm";
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(185, 285);
            this.txtMM.Multiline = true;
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(165, 34);
            this.txtMM.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã Môn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 487);
            this.Controls.Add(this.dsGV);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtNSGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butTim);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMGV;
        private System.Windows.Forms.DataGridView dsGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNSGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.Label label6;
    }
}