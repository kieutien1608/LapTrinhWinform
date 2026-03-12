namespace BTAP13032026
{
    partial class AddStudent
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
            this.labelMaSV = new System.Windows.Forms.Label();
            this.labelHovaTen = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.textBoxHovaTen = new System.Windows.Forms.TextBox();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.textBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Location = new System.Drawing.Point(167, 105);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(87, 16);
            this.labelMaSV.TabIndex = 0;
            this.labelMaSV.Text = "Mã sinh viên: ";
            // 
            // labelHovaTen
            // 
            this.labelHovaTen.AutoSize = true;
            this.labelHovaTen.Location = new System.Drawing.Point(167, 146);
            this.labelHovaTen.Name = "labelHovaTen";
            this.labelHovaTen.Size = new System.Drawing.Size(70, 16);
            this.labelHovaTen.TabIndex = 0;
            this.labelHovaTen.Text = "Họ và tên: ";
            this.labelHovaTen.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(167, 186);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.labelNgaySinh.TabIndex = 0;
            this.labelNgaySinh.Text = "Ngày sinh: ";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(167, 230);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.labelGioiTinh.TabIndex = 0;
            this.labelGioiTinh.Text = "Giới tính: ";
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Location = new System.Drawing.Point(167, 269);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(76, 16);
            this.labelMaLop.TabIndex = 0;
            this.labelMaLop.Text = "Mã lớp học:";
            this.labelMaLop.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Location = new System.Drawing.Point(167, 307);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(81, 16);
            this.labelTenLop.TabIndex = 0;
            this.labelTenLop.Text = "Tên lớp học:";
            this.labelTenLop.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(266, 38);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(262, 38);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Thêm Sinh Viên";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(300, 102);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(300, 22);
            this.textBoxMaSV.TabIndex = 1;
            // 
            // textBoxHovaTen
            // 
            this.textBoxHovaTen.Location = new System.Drawing.Point(300, 143);
            this.textBoxHovaTen.Name = "textBoxHovaTen";
            this.textBoxHovaTen.Size = new System.Drawing.Size(300, 22);
            this.textBoxHovaTen.TabIndex = 1;
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Location = new System.Drawing.Point(300, 183);
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.Size = new System.Drawing.Size(300, 22);
            this.textBoxNgaySinh.TabIndex = 1;
            // 
            // textBoxGioiTinh
            // 
            this.textBoxGioiTinh.Location = new System.Drawing.Point(300, 224);
            this.textBoxGioiTinh.Name = "textBoxGioiTinh";
            this.textBoxGioiTinh.Size = new System.Drawing.Size(300, 22);
            this.textBoxGioiTinh.TabIndex = 1;
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Location = new System.Drawing.Point(300, 263);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(300, 22);
            this.textBoxMaLop.TabIndex = 1;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Location = new System.Drawing.Point(300, 304);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(300, 22);
            this.textBoxTenLop.TabIndex = 1;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(170, 367);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(169, 42);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(431, 367);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(169, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Trở Về";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonThem);
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
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelMaSV);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.Label labelHovaTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.TextBox textBoxHovaTen;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.TextBox textBoxGioiTinh;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonBack;
    }
}