
namespace QuanLyTHPT
{
    partial class Form7
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
            this.tab12 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvTKD12 = new System.Windows.Forms.DataGridView();
            this.btnTim12 = new System.Windows.Forms.Button();
            this.cbbMon12 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTKHK12 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tab11 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTKD11 = new System.Windows.Forms.DataGridView();
            this.btnTim11 = new System.Windows.Forms.Button();
            this.cbbMon11 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTKHK11 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tab10 = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvTKM = new System.Windows.Forms.DataGridView();
            this.btnTimMon = new System.Windows.Forms.Button();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTKHK = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTK = new System.Windows.Forms.TabControl();
            this.tab12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKD12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHK12)).BeginInit();
            this.tab11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKD11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHK11)).BeginInit();
            this.tab10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHK)).BeginInit();
            this.tabTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab12
            // 
            this.tab12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab12.Controls.Add(this.label7);
            this.tab12.Controls.Add(this.dgvTKHK12);
            this.tab12.Controls.Add(this.label8);
            this.tab12.Controls.Add(this.cbbMon12);
            this.tab12.Controls.Add(this.btnTim12);
            this.tab12.Controls.Add(this.dgvTKD12);
            this.tab12.Controls.Add(this.label9);
            this.tab12.Location = new System.Drawing.Point(4, 25);
            this.tab12.Name = "tab12";
            this.tab12.Padding = new System.Windows.Forms.Padding(3);
            this.tab12.Size = new System.Drawing.Size(1134, 527);
            this.tab12.TabIndex = 2;
            this.tab12.Text = "Khối 12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Môn";
            // 
            // dgvTKD12
            // 
            this.dgvTKD12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKD12.Location = new System.Drawing.Point(433, 135);
            this.dgvTKD12.Name = "dgvTKD12";
            this.dgvTKD12.RowHeadersWidth = 51;
            this.dgvTKD12.RowTemplate.Height = 24;
            this.dgvTKD12.Size = new System.Drawing.Size(426, 80);
            this.dgvTKD12.TabIndex = 15;
            // 
            // btnTim12
            // 
            this.btnTim12.Location = new System.Drawing.Point(298, 213);
            this.btnTim12.Name = "btnTim12";
            this.btnTim12.Size = new System.Drawing.Size(75, 29);
            this.btnTim12.TabIndex = 16;
            this.btnTim12.Text = "Xem";
            this.btnTim12.UseVisualStyleBackColor = true;
            this.btnTim12.Click += new System.EventHandler(this.btnTim12_Click);
            // 
            // cbbMon12
            // 
            this.cbbMon12.FormattingEnabled = true;
            this.cbbMon12.Items.AddRange(new object[] {
            "Toan",
            "Ngu Van",
            "Ngoai Ngu",
            "Vat Ly",
            "Hoa Hoc",
            "The Duc",
            "Quoc Phong",
            "GDCD",
            "Lich Su",
            "Sinh Hoc"});
            this.cbbMon12.Location = new System.Drawing.Point(275, 170);
            this.cbbMon12.Name = "cbbMon12";
            this.cbbMon12.Size = new System.Drawing.Size(121, 24);
            this.cbbMon12.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(349, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Thống kê điểm trung bình các môn khối 12 (đơn vị: %)";
            // 
            // dgvTKHK12
            // 
            this.dgvTKHK12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHK12.Location = new System.Drawing.Point(433, 341);
            this.dgvTKHK12.Name = "dgvTKHK12";
            this.dgvTKHK12.RowHeadersWidth = 51;
            this.dgvTKHK12.RowTemplate.Height = 24;
            this.dgvTKHK12.Size = new System.Drawing.Size(426, 80);
            this.dgvTKHK12.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Thống kê hạnh kiểm học sinh khối 12 (đơn vị: %)";
            // 
            // tab11
            // 
            this.tab11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab11.Controls.Add(this.label4);
            this.tab11.Controls.Add(this.dgvTKHK11);
            this.tab11.Controls.Add(this.label5);
            this.tab11.Controls.Add(this.cbbMon11);
            this.tab11.Controls.Add(this.btnTim11);
            this.tab11.Controls.Add(this.dgvTKD11);
            this.tab11.Controls.Add(this.label6);
            this.tab11.Location = new System.Drawing.Point(4, 25);
            this.tab11.Name = "tab11";
            this.tab11.Padding = new System.Windows.Forms.Padding(3);
            this.tab11.Size = new System.Drawing.Size(1134, 527);
            this.tab11.TabIndex = 1;
            this.tab11.Text = "Khối 11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Môn";
            // 
            // dgvTKD11
            // 
            this.dgvTKD11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKD11.Location = new System.Drawing.Point(433, 135);
            this.dgvTKD11.Name = "dgvTKD11";
            this.dgvTKD11.RowHeadersWidth = 51;
            this.dgvTKD11.RowTemplate.Height = 24;
            this.dgvTKD11.Size = new System.Drawing.Size(426, 80);
            this.dgvTKD11.TabIndex = 8;
            // 
            // btnTim11
            // 
            this.btnTim11.Location = new System.Drawing.Point(298, 213);
            this.btnTim11.Name = "btnTim11";
            this.btnTim11.Size = new System.Drawing.Size(75, 29);
            this.btnTim11.TabIndex = 9;
            this.btnTim11.Text = "Xem";
            this.btnTim11.UseVisualStyleBackColor = true;
            this.btnTim11.Click += new System.EventHandler(this.btnTim11_Click);
            // 
            // cbbMon11
            // 
            this.cbbMon11.FormattingEnabled = true;
            this.cbbMon11.Items.AddRange(new object[] {
            "Toan",
            "Ngu Van",
            "Ngoai Ngu",
            "Vat Ly",
            "Hoa Hoc",
            "The Duc",
            "Quoc Phong",
            "GDCD",
            "Lich Su",
            "Sinh Hoc"});
            this.cbbMon11.Location = new System.Drawing.Point(275, 170);
            this.cbbMon11.Name = "cbbMon11";
            this.cbbMon11.Size = new System.Drawing.Size(121, 24);
            this.cbbMon11.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thống kê điểm trung bình các môn khối 11 (đơn vị: %)";
            // 
            // dgvTKHK11
            // 
            this.dgvTKHK11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHK11.Location = new System.Drawing.Point(433, 341);
            this.dgvTKHK11.Name = "dgvTKHK11";
            this.dgvTKHK11.RowHeadersWidth = 51;
            this.dgvTKHK11.RowTemplate.Height = 24;
            this.dgvTKHK11.Size = new System.Drawing.Size(426, 80);
            this.dgvTKHK11.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thống kê hạnh kiểm học sinh khối 11 (đơn vị: %)";
            // 
            // tab10
            // 
            this.tab10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab10.Controls.Add(this.label3);
            this.tab10.Controls.Add(this.dgvTKHK);
            this.tab10.Controls.Add(this.label2);
            this.tab10.Controls.Add(this.cbbMon);
            this.tab10.Controls.Add(this.btnTimMon);
            this.tab10.Controls.Add(this.dgvTKM);
            this.tab10.Controls.Add(this.Label1);
            this.tab10.Location = new System.Drawing.Point(4, 25);
            this.tab10.Name = "tab10";
            this.tab10.Padding = new System.Windows.Forms.Padding(3);
            this.tab10.Size = new System.Drawing.Size(1134, 527);
            this.tab10.TabIndex = 0;
            this.tab10.Text = "Khối 10";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(232, 104);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Môn";
            // 
            // dgvTKM
            // 
            this.dgvTKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKM.Location = new System.Drawing.Point(351, 104);
            this.dgvTKM.Name = "dgvTKM";
            this.dgvTKM.RowHeadersWidth = 51;
            this.dgvTKM.RowTemplate.Height = 24;
            this.dgvTKM.Size = new System.Drawing.Size(426, 80);
            this.dgvTKM.TabIndex = 1;
            // 
            // btnTimMon
            // 
            this.btnTimMon.Location = new System.Drawing.Point(216, 182);
            this.btnTimMon.Name = "btnTimMon";
            this.btnTimMon.Size = new System.Drawing.Size(75, 29);
            this.btnTimMon.TabIndex = 2;
            this.btnTimMon.Text = "Xem";
            this.btnTimMon.UseVisualStyleBackColor = true;
            this.btnTimMon.Click += new System.EventHandler(this.btnTimMon_Click);
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Items.AddRange(new object[] {
            "Toan",
            "Ngu Van",
            "Ngoai Ngu",
            "Vat Ly",
            "Hoa Hoc",
            "The Duc",
            "Quoc Phong",
            "GDCD",
            "Lich Su",
            "Sinh Hoc"});
            this.cbbMon.Location = new System.Drawing.Point(193, 139);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(121, 24);
            this.cbbMon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê điểm trung bình các môn khối 10 (đơn vị: %)";
            // 
            // dgvTKHK
            // 
            this.dgvTKHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHK.Location = new System.Drawing.Point(351, 310);
            this.dgvTKHK.Name = "dgvTKHK";
            this.dgvTKHK.RowHeadersWidth = 51;
            this.dgvTKHK.RowTemplate.Height = 24;
            this.dgvTKHK.Size = new System.Drawing.Size(426, 80);
            this.dgvTKHK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thống kê hạnh kiểm học sinh khối 10 (đơn vị: %)";
            // 
            // tabTK
            // 
            this.tabTK.Controls.Add(this.tab10);
            this.tabTK.Controls.Add(this.tab11);
            this.tabTK.Controls.Add(this.tab12);
            this.tabTK.Location = new System.Drawing.Point(0, 1);
            this.tabTK.Name = "tabTK";
            this.tabTK.SelectedIndex = 0;
            this.tabTK.Size = new System.Drawing.Size(1142, 556);
            this.tabTK.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 560);
            this.Controls.Add(this.tabTK);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.tab12.ResumeLayout(false);
            this.tab12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKD12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHK12)).EndInit();
            this.tab11.ResumeLayout(false);
            this.tab11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKD11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHK11)).EndInit();
            this.tab10.ResumeLayout(false);
            this.tab10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHK)).EndInit();
            this.tabTK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTKHK12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMon12;
        private System.Windows.Forms.Button btnTim12;
        private System.Windows.Forms.DataGridView dgvTKD12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tab11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTKHK11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMon11;
        private System.Windows.Forms.Button btnTim11;
        private System.Windows.Forms.DataGridView dgvTKD11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tab10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTKHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.Button btnTimMon;
        private System.Windows.Forms.DataGridView dgvTKM;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabControl tabTK;
    }
}