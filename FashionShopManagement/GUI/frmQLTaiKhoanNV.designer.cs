﻿namespace FashionShopApp.GUI
{
    partial class frmQLTaiKhoanNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTaiKhoanNV));
            this.txt_IdAcc = new System.Windows.Forms.TextBox();
            this.txt_tenTK = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_SearchTK = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IdAcc
            // 
            this.txt_IdAcc.Location = new System.Drawing.Point(317, 83);
            this.txt_IdAcc.Name = "txt_IdAcc";
            this.txt_IdAcc.Size = new System.Drawing.Size(265, 22);
            this.txt_IdAcc.TabIndex = 0;
            // 
            // txt_tenTK
            // 
            this.txt_tenTK.Location = new System.Drawing.Point(317, 124);
            this.txt_tenTK.Name = "txt_tenTK";
            this.txt_tenTK.Size = new System.Drawing.Size(265, 22);
            this.txt_tenTK.TabIndex = 1;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(317, 170);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(265, 22);
            this.txt_matkhau.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(114, 283);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(631, 192);
            this.dgv.TabIndex = 6;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Xoa.Image = global::FashionShopApp.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Xoa.Location = new System.Drawing.Point(571, 229);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 37);
            this.btn_Xoa.TabIndex = 41;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Reset.Location = new System.Drawing.Point(114, 230);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 37);
            this.btn_Reset.TabIndex = 43;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Them.Image = global::FashionShopApp.Properties.Resources.add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Them.Location = new System.Drawing.Point(214, 230);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(97, 37);
            this.btn_Them.TabIndex = 44;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_CapNhat.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhat.Location = new System.Drawing.Point(420, 229);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(145, 37);
            this.btn_CapNhat.TabIndex = 45;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(142, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã tài khoản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(142, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 29);
            this.label12.TabIndex = 47;
            this.label12.Text = "Tên tài khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(142, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 48;
            this.label11.Text = "Mật khẩu";
            // 
            // btn_SearchTK
            // 
            this.btn_SearchTK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchTK.FlatAppearance.BorderSize = 0;
            this.btn_SearchTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_SearchTK.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchTK.Image")));
            this.btn_SearchTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchTK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SearchTK.Location = new System.Drawing.Point(635, 134);
            this.btn_SearchTK.Name = "btn_SearchTK";
            this.btn_SearchTK.Size = new System.Drawing.Size(89, 33);
            this.btn_SearchTK.TabIndex = 80;
            this.btn_SearchTK.Text = "Tìm";
            this.btn_SearchTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchTK.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_Luu.Image = global::FashionShopApp.Properties.Resources.icons8_save_30;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Luu.Location = new System.Drawing.Point(317, 229);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(97, 37);
            this.btn_Luu.TabIndex = 81;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 51);
            this.label2.TabIndex = 82;
            this.label2.Text = "DANH SÁCH TÀI KHOẢN NHÂN VIÊN";
            // 
            // frmQLTaiKhoanNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 487);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_SearchTK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tenTK);
            this.Controls.Add(this.txt_IdAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLTaiKhoanNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdAcc;
        private System.Windows.Forms.TextBox txt_tenTK;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_SearchTK;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label2;
    }
}