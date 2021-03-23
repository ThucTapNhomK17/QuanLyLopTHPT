
namespace QuanLyTHPT
{
    partial class Form2
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
            this.butGV = new System.Windows.Forms.Button();
            this.butHS = new System.Windows.Forms.Button();
            this.butQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGV
            // 
            this.butGV.Location = new System.Drawing.Point(85, 52);
            this.butGV.Name = "butGV";
            this.butGV.Size = new System.Drawing.Size(110, 55);
            this.butGV.TabIndex = 0;
            this.butGV.Text = "Giáo Viên";
            this.butGV.UseVisualStyleBackColor = true;
            this.butGV.Click += new System.EventHandler(this.butGV_Click);
            // 
            // butHS
            // 
            this.butHS.Location = new System.Drawing.Point(85, 143);
            this.butHS.Name = "butHS";
            this.butHS.Size = new System.Drawing.Size(110, 56);
            this.butHS.TabIndex = 0;
            this.butHS.Text = "Học Sinh";
            this.butHS.UseVisualStyleBackColor = true;
            this.butHS.Click += new System.EventHandler(this.butHS_Click);
            // 
            // butQL
            // 
            this.butQL.Location = new System.Drawing.Point(101, 245);
            this.butQL.Name = "butQL";
            this.butQL.Size = new System.Drawing.Size(75, 34);
            this.butQL.TabIndex = 0;
            this.butQL.Text = "Quay Lại";
            this.butQL.UseVisualStyleBackColor = true;
            this.butQL.Click += new System.EventHandler(this.butQL_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 291);
            this.Controls.Add(this.butQL);
            this.Controls.Add(this.butHS);
            this.Controls.Add(this.butGV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGV;
        private System.Windows.Forms.Button butHS;
        private System.Windows.Forms.Button butQL;
    }
}