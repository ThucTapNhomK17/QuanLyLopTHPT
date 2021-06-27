
namespace QuanLyTHPT
{
    partial class Lop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenGVCN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dsCN = new System.Windows.Forms.DataGridView();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtML = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dsLop = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.butTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.quanLyTHPTDataSet = new QuanLyTHPT.QuanLyTHPTDataSet();
            this.hocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocsinhTableAdapter = new QuanLyTHPT.QuanLyTHPTDataSetTableAdapters.hocsinhTableAdapter();
            this.hocsinhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTHPTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSuaGVCN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCN)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLop)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTenGVCN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dsCN);
            this.panel1.Controls.Add(this.txtSS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtML);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 534);
            this.panel1.TabIndex = 24;
            // 
            // txtTenGVCN
            // 
            this.txtTenGVCN.Location = new System.Drawing.Point(124, 309);
            this.txtTenGVCN.Multiline = true;
            this.txtTenGVCN.Name = "txtTenGVCN";
            this.txtTenGVCN.Size = new System.Drawing.Size(165, 34);
            this.txtTenGVCN.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tên GVCN";
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(124, 230);
            this.txtCN.Multiline = true;
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(165, 34);
            this.txtCN.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã GVCN";
            // 
            // dsCN
            // 
            this.dsCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCN.Location = new System.Drawing.Point(11, 367);
            this.dsCN.Name = "dsCN";
            this.dsCN.RowHeadersWidth = 51;
            this.dsCN.RowTemplate.Height = 24;
            this.dsCN.Size = new System.Drawing.Size(278, 156);
            this.dsCN.TabIndex = 26;
            this.dsCN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsCN_CellContentClick);
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(124, 153);
            this.txtSS.Multiline = true;
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(165, 34);
            this.txtSS.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Lớp";
            // 
            // txtML
            // 
            this.txtML.Location = new System.Drawing.Point(124, 5);
            this.txtML.Multiline = true;
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(165, 34);
            this.txtML.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sĩ số";
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(124, 77);
            this.txtTL.Multiline = true;
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(165, 34);
            this.txtTL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "DANH SÁCH LỚP";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dsLop);
            this.panel2.Location = new System.Drawing.Point(323, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 226);
            this.panel2.TabIndex = 25;
            // 
            // dsLop
            // 
            this.dsLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsLop.Location = new System.Drawing.Point(9, 24);
            this.dsLop.Name = "dsLop";
            this.dsLop.RowHeadersWidth = 51;
            this.dsLop.RowTemplate.Height = 24;
            this.dsLop.ShowRowErrors = false;
            this.dsLop.Size = new System.Drawing.Size(773, 189);
            this.dsLop.TabIndex = 12;
            this.dsLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsLop_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSuaGVCN);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.butTim);
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Location = new System.Drawing.Point(323, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 289);
            this.panel3.TabIndex = 27;
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
            this.button4.Location = new System.Drawing.Point(442, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 39);
            this.button4.TabIndex = 24;
            this.button4.Text = "↩️";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.butTim.Location = new System.Drawing.Point(328, 148);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(81, 39);
            this.butTim.TabIndex = 11;
            this.butTim.Text = "Tìm 🔎 ";
            this.butTim.UseVisualStyleBackColor = false;
            this.butTim.Click += new System.EventHandler(this.butTim_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(328, 77);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(205, 34);
            this.txtTim.TabIndex = 10;
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
            this.label5.Location = new System.Drawing.Point(264, 84);
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
            // hocsinhBindingSource1
            // 
            this.hocsinhBindingSource1.DataMember = "hocsinh";
            this.hocsinhBindingSource1.DataSource = this.quanLyTHPTDataSetBindingSource;
            // 
            // quanLyTHPTDataSetBindingSource
            // 
            this.quanLyTHPTDataSetBindingSource.DataSource = this.quanLyTHPTDataSet;
            this.quanLyTHPTDataSetBindingSource.Position = 0;
            // 
            // btnSuaGVCN
            // 
            this.btnSuaGVCN.BackColor = System.Drawing.Color.White;
            this.btnSuaGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGVCN.Location = new System.Drawing.Point(112, 214);
            this.btnSuaGVCN.Name = "btnSuaGVCN";
            this.btnSuaGVCN.Size = new System.Drawing.Size(76, 50);
            this.btnSuaGVCN.TabIndex = 26;
            this.btnSuaGVCN.Text = "Sửa GVCN";
            this.btnSuaGVCN.UseVisualStyleBackColor = false;
            this.btnSuaGVCN.Click += new System.EventHandler(this.btnSuaGVCN_Click);
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Lop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCN)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLop)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTHPTDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dsLop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button butTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private QuanLyTHPTDataSet quanLyTHPTDataSet;
        private System.Windows.Forms.BindingSource hocsinhBindingSource;
        private QuanLyTHPTDataSetTableAdapters.hocsinhTableAdapter hocsinhTableAdapter;
        private System.Windows.Forms.BindingSource hocsinhBindingSource1;
        private System.Windows.Forms.BindingSource quanLyTHPTDataSetBindingSource;
        private System.Windows.Forms.DataGridView dsCN;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenGVCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSuaGVCN;
    }
}