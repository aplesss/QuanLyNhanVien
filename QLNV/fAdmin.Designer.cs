namespace QLNV
{
    partial class fAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btResetPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btViewAcc = new System.Windows.Forms.Button();
            this.btDeleteAcc = new System.Windows.Forms.Button();
            this.btChangeAcc = new System.Windows.Forms.Button();
            this.btAddAcc = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dtgvAcc = new System.Windows.Forms.DataGridView();
            this.tbType = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 388);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btResetPass);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Location = new System.Drawing.Point(409, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(468, 320);
            this.panel9.TabIndex = 8;
            // 
            // btResetPass
            // 
            this.btResetPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetPass.Location = new System.Drawing.Point(297, 186);
            this.btResetPass.Name = "btResetPass";
            this.btResetPass.Size = new System.Drawing.Size(165, 66);
            this.btResetPass.TabIndex = 4;
            this.btResetPass.Text = "Đặt lại mật khẩu";
            this.btResetPass.UseVisualStyleBackColor = true;
            this.btResetPass.Click += new System.EventHandler(this.btResetPass_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 55);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại tài khoản";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tbName);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(3, 64);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(462, 55);
            this.panel12.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(149, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 30);
            this.tbName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên hiển thị";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tbUsername);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Location = new System.Drawing.Point(3, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(462, 55);
            this.panel13.TabIndex = 0;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(149, 10);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(310, 30);
            this.tbUsername.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên đăng nhập";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btViewAcc);
            this.panel14.Controls.Add(this.btDeleteAcc);
            this.panel14.Controls.Add(this.btChangeAcc);
            this.panel14.Controls.Add(this.btAddAcc);
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(400, 56);
            this.panel14.TabIndex = 7;
            // 
            // btViewAcc
            // 
            this.btViewAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewAcc.Location = new System.Drawing.Point(294, 3);
            this.btViewAcc.Name = "btViewAcc";
            this.btViewAcc.Size = new System.Drawing.Size(101, 50);
            this.btViewAcc.TabIndex = 3;
            this.btViewAcc.Text = "Xem";
            this.btViewAcc.UseVisualStyleBackColor = true;
            this.btViewAcc.Click += new System.EventHandler(this.btViewAcc_Click);
            // 
            // btDeleteAcc
            // 
            this.btDeleteAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteAcc.Location = new System.Drawing.Point(193, 3);
            this.btDeleteAcc.Name = "btDeleteAcc";
            this.btDeleteAcc.Size = new System.Drawing.Size(95, 50);
            this.btDeleteAcc.TabIndex = 2;
            this.btDeleteAcc.Text = "Xóa";
            this.btDeleteAcc.UseVisualStyleBackColor = true;
            this.btDeleteAcc.Click += new System.EventHandler(this.btDeleteAcc_Click);
            // 
            // btChangeAcc
            // 
            this.btChangeAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeAcc.Location = new System.Drawing.Point(90, 3);
            this.btChangeAcc.Name = "btChangeAcc";
            this.btChangeAcc.Size = new System.Drawing.Size(97, 50);
            this.btChangeAcc.TabIndex = 1;
            this.btChangeAcc.Text = "Sửa";
            this.btChangeAcc.UseVisualStyleBackColor = true;
            this.btChangeAcc.Click += new System.EventHandler(this.btChangeAcc_Click);
            // 
            // btAddAcc
            // 
            this.btAddAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAcc.Location = new System.Drawing.Point(3, 3);
            this.btAddAcc.Name = "btAddAcc";
            this.btAddAcc.Size = new System.Drawing.Size(81, 50);
            this.btAddAcc.TabIndex = 0;
            this.btAddAcc.Text = "Thêm";
            this.btAddAcc.UseVisualStyleBackColor = true;
            this.btAddAcc.Click += new System.EventHandler(this.btAddAcc_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dtgvAcc);
            this.panel15.Location = new System.Drawing.Point(3, 62);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(400, 326);
            this.panel15.TabIndex = 6;
            // 
            // dtgvAcc
            // 
            this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAcc.Location = new System.Drawing.Point(3, 3);
            this.dtgvAcc.Name = "dtgvAcc";
            this.dtgvAcc.RowTemplate.Height = 24;
            this.dtgvAcc.Size = new System.Drawing.Size(392, 320);
            this.dtgvAcc.TabIndex = 0;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.Location = new System.Drawing.Point(149, 10);
            this.tbType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(38, 30);
            this.tbType.TabIndex = 1;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 411);
            this.Controls.Add(this.panel1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btResetPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btViewAcc;
        private System.Windows.Forms.Button btDeleteAcc;
        private System.Windows.Forms.Button btChangeAcc;
        private System.Windows.Forms.Button btAddAcc;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dtgvAcc;
        private System.Windows.Forms.NumericUpDown tbType;
    }
}