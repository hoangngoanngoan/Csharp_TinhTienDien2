namespace Csharp_TinhTienDien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labKetQua = new Label();
            txtSoDien = new TextBox();
            lsbKetQua = new ListBox();
            btnTinh = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 28);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính tiền điện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 1;
            label2.Text = "Nhập số điện:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 1;
            label3.Text = "Tổng số tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 22);
            label4.TabIndex = 1;
            label4.Text = "Bảng hóa đơn:";
            // 
            // labKetQua
            // 
            labKetQua.AutoSize = true;
            labKetQua.Location = new Point(222, 119);
            labKetQua.Margin = new Padding(4, 0, 4, 0);
            labKetQua.Name = "labKetQua";
            labKetQua.Size = new Size(77, 22);
            labKetQua.TabIndex = 1;
            labKetQua.Text = "Kết quả:";
            // 
            // txtSoDien
            // 
            txtSoDien.Location = new Point(222, 71);
            txtSoDien.Name = "txtSoDien";
            txtSoDien.Size = new Size(157, 29);
            txtSoDien.TabIndex = 2;
            // 
            // lsbKetQua
            // 
            lsbKetQua.FormattingEnabled = true;
            lsbKetQua.ItemHeight = 22;
            lsbKetQua.Location = new Point(74, 201);
            lsbKetQua.Name = "lsbKetQua";
            lsbKetQua.Size = new Size(305, 202);
            lsbKetQua.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(185, 422);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(285, 422);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 495);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(lsbKetQua);
            Controls.Add(txtSoDien);
            Controls.Add(label4);
            Controls.Add(labKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labKetQua;
        private TextBox txtSoDien;
        private ListBox lsbKetQua;
        private Button btnTinh;
        private Button btnThoat;
    }
}
