namespace BTAP13032026
{
    partial class AddClass
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
            this.buttonThem = new System.Windows.Forms.Button();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(187, 369);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(169, 42);
            this.buttonThem.TabIndex = 17;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Location = new System.Drawing.Point(179, 151);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(81, 16);
            this.labelTenLop.TabIndex = 3;
            this.labelTenLop.Text = "Tên lớp học:";
            this.labelTenLop.Click += new System.EventHandler(this.labelTenLop_Click);
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Location = new System.Drawing.Point(184, 107);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(76, 16);
            this.labelMaLop.TabIndex = 4;
            this.labelMaLop.Text = "Mã lớp học:";
            this.labelMaLop.Click += new System.EventHandler(this.labelMaLop_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(283, 40);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(247, 38);
            this.labelAdd.TabIndex = 8;
            this.labelAdd.Text = "Thêm Lớp Học";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelTenLop);
            this.Controls.Add(this.labelMaLop);
            this.Controls.Add(this.labelAdd);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}