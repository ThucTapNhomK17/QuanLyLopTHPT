
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
            this.components = new System.ComponentModel.Container();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbmamon = new System.Windows.Forms.ComboBox();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.cbbGT = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dsGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbTimMM = new System.Windows.Forms.ComboBox();
            this.cbbTimGT = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.butTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.quanLyTHPTDataSet = new QuanLyTHPT.QuanLyTHPTDataSet();
            this.hocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocsinhTableAdapter = new QuanLyTHPT.QuanLyTHPTDataSetTableAdapters.hocsinhTableAdapter();
            this.quanLyTHPTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocsinhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cbbmamon
            // 
            this.cbbmamon.FormattingEnabled = true;
            this.cbbmamon.Items.AddRange(new object[] {
            "MM01      ",
            "MM02      ",
            "MM03      ",
            "MM04      ",
            "MM05      ",
            "MM06      ",
            "MM07      ",
            "MM08      ",
            "MM09      ",
            "MM10      "});
            this.cbbmamon.Location = new System.Drawing.Point(124, 210);
            this.cbbmamon.Name = "cbbmamon";
            this.cbbmamon.Size = new System.Drawing.Size(165, 24);
            this.cbbmamon.TabIndex = 21;
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(124, 143);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(165, 22);
            this.dtpNS.TabIndex = 20;
            // 
            // cbbGT
            // 
            this.cbbGT.FormattingEnabled = true;
            this.cbbGT.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbGT.Location = new System.Drawing.Point(124, 276);
            this.cbbGT.Name = "cbbGT";
            this.cbbGT.Size = new System.Drawing.Size(165, 24);
            this.cbbGT.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dsGV);
            this.panel2.Location = new System.Drawing.Point(321, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 226);
            this.panel2.TabIndex = 25;
            // 
            // dsGV
            // 
            this.dsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsGV.Location = new System.Drawing.Point(9, 24);
            this.dsGV.Name = "dsGV";
            this.dsGV.RowHeadersWidth = 51;
            this.dsGV.RowTemplate.Height = 24;
            this.dsGV.ShowRowErrors = false;
            this.dsGV.Size = new System.Drawing.Size(773, 189);
            this.dsGV.TabIndex = 12;
            this.dsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsGV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbbTimMM);
            this.panel3.Controls.Add(this.cbbTimGT);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.butTim);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Location = new System.Drawing.Point(321, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 289);
            this.panel3.TabIndex = 27;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(328, 61);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(165, 34);
            this.txtTim.TabIndex = 26;
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
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mã môn";
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
            // cbbTimMM
            // 
            this.cbbTimMM.FormattingEnabled = true;
            this.cbbTimMM.Items.AddRange(new object[] {
            "MM01      ",
            "MM02      ",
            "MM03      ",
            "MM04      ",
            "MM05      ",
            "MM06      ",
            "MM07      ",
            "MM08      ",
            "MM09      ",
            "MM10      "});
            this.cbbTimMM.Location = new System.Drawing.Point(328, 173);
            this.cbbTimMM.Name = "cbbTimMM";
            this.cbbTimMM.Size = new System.Drawing.Size(104, 24);
            this.cbbTimMM.TabIndex = 21;
            // 
            // cbbTimGT
            // 
            this.cbbTimGT.FormattingEnabled = true;
            this.cbbTimGT.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbTimGT.Location = new System.Drawing.Point(328, 122);
            this.cbbTimGT.Name = "cbbTimGT";
            this.cbbTimGT.Size = new System.Drawing.Size(104, 24);
            this.cbbTimGT.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(9, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(9, 214);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 50);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(9, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 50);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(9, 77);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 47);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbmamon);
            this.panel1.Controls.Add(this.dtpNS);
            this.panel1.Controls.Add(this.cbbGT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtluong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMAGV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTGV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 534);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã môn";
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(124, 343);
            this.txtluong.Multiline = true;
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(165, 35);
            this.txtluong.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(124, 5);
            this.txtMAGV.Multiline = true;
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(165, 34);
            this.txtMAGV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lương";
            // 
            // txtTGV
            // 
            this.txtTGV.Location = new System.Drawing.Point(124, 72);
            this.txtTGV.Multiline = true;
            this.txtTGV.Name = "txtTGV";
            this.txtTGV.Size = new System.Drawing.Size(165, 34);
            this.txtTGV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 560);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbmamon;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.ComboBox cbbGT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dsGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbTimMM;
        private System.Windows.Forms.ComboBox cbbTimGT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button butTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private QuanLyTHPTDataSet quanLyTHPTDataSet;
        private System.Windows.Forms.BindingSource hocsinhBindingSource;
        private QuanLyTHPTDataSetTableAdapters.hocsinhTableAdapter hocsinhTableAdapter;
        private System.Windows.Forms.BindingSource quanLyTHPTDataSetBindingSource;
        private System.Windows.Forms.BindingSource hocsinhBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
    }
}