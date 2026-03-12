namespace BTAP13032026
{
    partial class EditStudent
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.textBoxHovaTen = new System.Windows.Forms.TextBox();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelHovaTen = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelMaSv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(448, 369);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(169, 42);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Trở Về";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(187, 369);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(169, 42);
            this.buttonCapNhat.TabIndex = 17;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Location = new System.Drawing.Point(317, 306);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(300, 22);
            this.textBoxTenLop.TabIndex = 10;
            this.textBoxTenLop.TextChanged += new System.EventHandler(this.textBoxTenLop_TextChanged);
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Location = new System.Drawing.Point(317, 265);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(300, 22);
            this.textBoxMaLop.TabIndex = 11;
            this.textBoxMaLop.TextChanged += new System.EventHandler(this.textBoxMaLop_TextChanged);
            // 
            // textBoxGioiTinh
            // 
            this.textBoxGioiTinh.Location = new System.Drawing.Point(317, 226);
            this.textBoxGioiTinh.Name = "textBoxGioiTinh";
            this.textBoxGioiTinh.Size = new System.Drawing.Size(300, 22);
            this.textBoxGioiTinh.TabIndex = 12;
            this.textBoxGioiTinh.TextChanged += new System.EventHandler(this.textBoxGioiTinh_TextChanged);
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Location = new System.Drawing.Point(317, 185);
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.Size = new System.Drawing.Size(300, 22);
            this.textBoxNgaySinh.TabIndex = 13;
            this.textBoxNgaySinh.TextChanged += new System.EventHandler(this.textBoxNgaySinh_TextChanged);
            // 
            // textBoxHovaTen
            // 
            this.textBoxHovaTen.Location = new System.Drawing.Point(317, 145);
            this.textBoxHovaTen.Name = "textBoxHovaTen";
            this.textBoxHovaTen.Size = new System.Drawing.Size(300, 22);
            this.textBoxHovaTen.TabIndex = 14;
            this.textBoxHovaTen.TextChanged += new System.EventHandler(this.textBoxHovaTen_TextChanged);
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(317, 104);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(300, 22);
            this.textBoxMaSV.TabIndex = 15;
            this.textBoxMaSV.TextChanged += new System.EventHandler(this.textBoxMaSV_TextChanged);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Location = new System.Drawing.Point(184, 309);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(81, 16);
            this.labelTenLop.TabIndex = 3;
            this.labelTenLop.Text = "Tên lớp học:";
            this.labelTenLop.Click += new System.EventHandler(this.labelTenLop_Click);
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Location = new System.Drawing.Point(184, 271);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(76, 16);
            this.labelMaLop.TabIndex = 4;
            this.labelMaLop.Text = "Mã lớp học:";
            this.labelMaLop.Click += new System.EventHandler(this.labelMaLop_Click);
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(184, 232);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.labelGioiTinh.TabIndex = 5;
            this.labelGioiTinh.Text = "Giới tính: ";
            this.labelGioiTinh.Click += new System.EventHandler(this.labelGioiTinh_Click);
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(184, 188);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.labelNgaySinh.TabIndex = 6;
            this.labelNgaySinh.Text = "Ngày sinh: ";
            this.labelNgaySinh.Click += new System.EventHandler(this.labelNgaySinh_Click);
            // 
            // labelHovaTen
            // 
            this.labelHovaTen.AutoSize = true;
            this.labelHovaTen.Location = new System.Drawing.Point(184, 148);
            this.labelHovaTen.Name = "labelHovaTen";
            this.labelHovaTen.Size = new System.Drawing.Size(70, 16);
            this.labelHovaTen.TabIndex = 7;
            this.labelHovaTen.Text = "Họ và tên: ";
            this.labelHovaTen.Click += new System.EventHandler(this.labelHovaTen_Click);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(237, 40);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(317, 38);
            this.labelEdit.TabIndex = 8;
            this.labelEdit.Text = "Cập Nhật Sinh Viên";
            this.labelEdit.Click += new System.EventHandler(this.labelEdit_Click);
            // 
            // labelMaSv
            // 
            this.labelMaSv.AutoSize = true;
            this.labelMaSv.Location = new System.Drawing.Point(184, 107);
            this.labelMaSv.Name = "labelMaSv";
            this.labelMaSv.Size = new System.Drawing.Size(87, 16);
            this.labelMaSv.TabIndex = 9;
            this.labelMaSv.Text = "Mã sinh viên: ";
            this.labelMaSv.Click += new System.EventHandler(this.labelMaSv_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.textBoxTenLop);
            this.Controls.Add(this.textBoxMaLop);
            this.Controls.Add(this.textBoxGioiTinh);
            this.Controls.Add(this.textBoxNgaySinh);
            this.Controls.Add(this.textBoxHovaTen);
            this.Controls.Add(this.textBoxMaSV);
            this.Controls.Add(this.labelTenLop);
            this.Controls.Add(this.labelMaLop);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelHovaTen);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelMaSv);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.TextBox textBoxGioiTinh;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.TextBox textBoxHovaTen;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelHovaTen;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelMaSv;
    }
}