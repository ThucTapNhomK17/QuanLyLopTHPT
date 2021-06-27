
namespace QuanLyTHPT
{
    partial class Form4
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
            this.dsHS = new System.Windows.Forms.DataGridView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMHS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butTim = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbmalop = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbHK = new System.Windows.Forms.ComboBox();
            this.cbbGT = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbTL = new System.Windows.Forms.ComboBox();
            this.cbbTGT = new System.Windows.Forms.ComboBox();
            this.quanLyTHPTDataSet = new QuanLyTHPT.QuanLyTHPTDataSet();
            this.hocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocsinhTableAdapter = new QuanLyTHPT.QuanLyTHPTDataSetTableAdapters.hocsinhTableAdapter();
            this.quanLyTHPTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocsinhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNhapdiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsHS
            // 
            this.dsHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHS.Location = new System.Drawing.Point(9, 24);
            this.dsHS.Name = "dsHS";
            this.dsHS.RowHeadersWidth = 51;
            this.dsHS.RowTemplate.Height = 24;
            this.dsHS.ShowRowErrors = false;
            this.dsHS.Size = new System.Drawing.Size(773, 189);
            this.dsHS.TabIndex = 12;
            this.dsHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsHS_CellContentClick);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(328, 61);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(205, 34);
            this.txtTim.TabIndex = 10;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(124, 200);
            this.txtNS.Multiline = true;
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(165, 34);
            this.txtNS.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nơi Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtTHS
            // 
            this.txtTHS.Location = new System.Drawing.Point(124, 72);
            this.txtTHS.Multiline = true;
            this.txtTHS.Name = "txtTHS";
            this.txtTHS.Size = new System.Drawing.Size(165, 34);
            this.txtTHS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Học Sinh";
            // 
            // txtMHS
            // 
            this.txtMHS.Location = new System.Drawing.Point(124, 5);
            this.txtMHS.Multiline = true;
            this.txtMHS.Name = "txtMHS";
            this.txtMHS.Size = new System.Drawing.Size(165, 34);
            this.txtMHS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Học Sinh";
            // 
            // butTim
            // 
            this.butTim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTim.Location = new System.Drawing.Point(328, 219);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(81, 39);
            this.butTim.TabIndex = 11;
            this.butTim.Text = "Tìm 🔎 ";
            this.butTim.UseVisualStyleBackColor = false;
            this.butTim.Click += new System.EventHandler(this.butTim_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(9, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã Lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hạnh Kiểm";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(9, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNhapdiem);
            this.panel1.Controls.Add(this.cbbmalop);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbbHK);
            this.panel1.Controls.Add(this.cbbGT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMHS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTHS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 534);
            this.panel1.TabIndex = 20;
            // 
            // cbbmalop
            // 
            this.cbbmalop.FormattingEnabled = true;
            this.cbbmalop.Items.AddRange(new object[] {
            "A1K1      ",
            "A1K2      ",
            "A1K3      ",
            "A2K1      ",
            "A2K2      ",
            "A2K3      ",
            "A3K1      ",
            "A3K2      ",
            "A3K3      ",
            "A4K1      ",
            "A4K2      ",
            "A4K3      ",
            "A5K1      ",
            "A5K2      ",
            "A5K3      ",
            "B10K1     ",
            "B10K2     ",
            "B10K3     ",
            "B6K1      ",
            "B6K2      ",
            "B6K3      ",
            "B7K1      ",
            "B7K2      ",
            "B7K3      ",
            "B8K1      ",
            "B8K2      ",
            "B8K3      ",
            "B9K1      ",
            "B9K2      ",
            "B9K3      "});
            this.cbbmalop.Location = new System.Drawing.Point(124, 278);
            this.cbbmalop.Name = "cbbmalop";
            this.cbbmalop.Size = new System.Drawing.Size(165, 24);
            this.cbbmalop.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // cbbHK
            // 
            this.cbbHK.FormattingEnabled = true;
            this.cbbHK.Items.AddRange(new object[] {
            "Tot",
            "Kha ",
            "Trung binh"});
            this.cbbHK.Location = new System.Drawing.Point(124, 406);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.Size = new System.Drawing.Size(165, 24);
            this.cbbHK.TabIndex = 21;
            // 
            // cbbGT
            // 
            this.cbbGT.FormattingEnabled = true;
            this.cbbGT.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbGT.Location = new System.Drawing.Point(124, 339);
            this.cbbGT.Name = "cbbGT";
            this.cbbGT.Size = new System.Drawing.Size(165, 24);
            this.cbbGT.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dsHS);
            this.panel2.Location = new System.Drawing.Point(321, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 226);
            this.panel2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(307, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "DANH SÁCH HỌC SINH";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbbTL);
            this.panel3.Controls.Add(this.cbbTGT);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.butTim);
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(321, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 289);
            this.panel3.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(392, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tìm kiếm";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(435, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 39);
            this.button4.TabIndex = 24;
            this.button4.Text = "↩️";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mã lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Giới tính";
            // 
            // cbbTL
            // 
            this.cbbTL.FormattingEnabled = true;
            this.cbbTL.Items.AddRange(new object[] {
            "A1K1      ",
            "A1K2      ",
            "A1K3      ",
            "A2K1      ",
            "A2K2      ",
            "A2K3      ",
            "A3K1      ",
            "A3K2      ",
            "A3K3      ",
            "A4K1      ",
            "A4K2      ",
            "A4K3      ",
            "A5K1      ",
            "A5K2      ",
            "A5K3      ",
            "B10K1     ",
            "B10K2     ",
            "B10K3     ",
            "B6K1      ",
            "B6K2      ",
            "B6K3      ",
            "B7K1      ",
            "B7K2      ",
            "B7K3      ",
            "B8K1      ",
            "B8K2      ",
            "B8K3      ",
            "B9K1      ",
            "B9K2      ",
            "B9K3      "});
            this.cbbTL.Location = new System.Drawing.Point(328, 173);
            this.cbbTL.Name = "cbbTL";
            this.cbbTL.Size = new System.Drawing.Size(104, 24);
            this.cbbTL.TabIndex = 21;
            // 
            // cbbTGT
            // 
            this.cbbTGT.FormattingEnabled = true;
            this.cbbTGT.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbTGT.Location = new System.Drawing.Point(328, 122);
            this.cbbTGT.Name = "cbbTGT";
            this.cbbTGT.Size = new System.Drawing.Size(104, 24);
            this.cbbTGT.TabIndex = 20;
            // 
            // quanLyTHPTDataSet
            // 
            this.quanLyTHPTDataSet.DataSetName = "QuanLyTHPTDataSet";
            this.quanLyTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocsinhBindingSource
            // 
            this.hocsinhBindingSource.DataMember = "hocsinh";
            this.hocsinhBindingSource.DataSource = this.quanLyTHPTDataSet;
            // 
            // hocsinhTableAdapter
            // 
            this.hocsinhTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyTHPTDataSetBindingSource
            // 
            this.quanLyTHPTDataSetBindingSource.DataSource = this.quanLyTHPTDataSet;
            this.quanLyTHPTDataSetBindingSource.Position = 0;
            // 
            // hocsinhBindingSource1
            // 
            this.hocsinhBindingSource1.DataMember = "hocsinh";
            this.hocsinhBindingSource1.DataSource = this.quanLyTHPTDataSetBindingSource;
            // 
            // btnNhapdiem
            // 
            this.btnNhapdiem.BackColor = System.Drawing.Color.White;
            this.btnNhapdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapdiem.Location = new System.Drawing.Point(4, 471);
            this.btnNhapdiem.Name = "btnNhapdiem";
            this.btnNhapdiem.Size = new System.Drawing.Size(285, 50);
            this.btnNhapdiem.TabIndex = 26;
            this.btnNhapdiem.Text = "Nhập điểm ";
            this.btnNhapdiem.UseVisualStyleBackColor = false;
            this.btnNhapdiem.Click += new System.EventHandler(this.btnNhapdiem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 560);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsHS;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butTim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbGT;
        private QuanLyTHPTDataSet quanLyTHPTDataSet;
        private System.Windows.Forms.BindingSource hocsinhBindingSource;
        private QuanLyTHPTDataSetTableAdapters.hocsinhTableAdapter hocsinhTableAdapter;
        private System.Windows.Forms.ComboBox cbbHK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbTGT;
        private System.Windows.Forms.ComboBox cbbmalop;
        private System.Windows.Forms.BindingSource quanLyTHPTDataSetBindingSource;
        private System.Windows.Forms.BindingSource hocsinhBindingSource1;
        private System.Windows.Forms.ComboBox cbbTL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNhapdiem;
    }
}