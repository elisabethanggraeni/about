namespace About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Caslon Pro Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(322, 3);
            label1.Name = "label1";
            label1.Size = new Size(102, 51);
            label1.TabIndex = 0;
            label1.Text = "About";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(205, 216);
            label2.Name = "label2";
            label2.Size = new Size(70, 34);
            label2.TabIndex = 1;
            label2.Text = "Nama ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(339, 216);
            label3.Name = "label3";
            label3.Size = new Size(183, 34);
            label3.TabIndex = 2;
            label3.Text = "Elisabeth Anggraeni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(205, 250);
            label4.Name = "label4";
            label4.Size = new Size(128, 34);
            label4.TabIndex = 3;
            label4.Text = "Tanggal lahir ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 250);
            label5.Name = "label5";
            label5.Size = new Size(127, 34);
            label5.TabIndex = 4;
            label5.Text = "04 April 2004";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(205, 284);
            label6.Name = "label6";
            label6.Size = new Size(63, 34);
            label6.TabIndex = 5;
            label6.Text = "Umur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(339, 284);
            label7.Name = "label7";
            label7.Size = new Size(92, 34);
            label7.TabIndex = 6;
            label7.Text = "19 Tahun";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(205, 318);
            label8.Name = "label8";
            label8.Size = new Size(76, 34);
            label8.TabIndex = 7;
            label8.Text = "Jurusan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(339, 318);
            label9.Name = "label9";
            label9.Size = new Size(111, 34);
            label9.TabIndex = 8;
            label9.Text = "Informatika";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(205, 352);
            label10.Name = "label10";
            label10.Size = new Size(89, 34);
            label10.TabIndex = 9;
            label10.Text = "Semester";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Adobe Caslon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(339, 352);
            label11.Name = "label11";
            label11.Size = new Size(25, 34);
            label11.TabIndex = 10;
            label11.Text = "3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
    }
}