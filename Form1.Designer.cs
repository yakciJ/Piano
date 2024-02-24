namespace Piano
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Key2Name = new Label();
            label1 = new Label();
            Key1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._24PianoKey;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1296, 600);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 233);
            label2.Name = "label2";
            label2.Size = new Size(37, 38);
            label2.TabIndex = 3;
            label2.Text = "A";
            // 
            // Key2Name
            // 
            Key2Name.AutoSize = true;
            Key2Name.BackColor = Color.White;
            Key2Name.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Key2Name.Location = new Point(136, 233);
            Key2Name.Name = "Key2Name";
            Key2Name.Size = new Size(38, 38);
            Key2Name.TabIndex = 4;
            Key2Name.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 233);
            label1.Name = "label1";
            label1.Size = new Size(36, 38);
            label1.TabIndex = 5;
            label1.Text = "C";
            // 
            // Key1
            // 
            Key1.Location = new Point(0, 0);
            Key1.Margin = new Padding(0);
            Key1.Name = "Key1";
            Key1.Size = new Size(95, 287);
            Key1.TabIndex = 0;
            Key1.Text = "Key1";
            Key1.UseVisualStyleBackColor = true;
            Key1.Visible = false;
            Key1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 601);
            Controls.Add(Key1);
            Controls.Add(label1);
            Controls.Add(Key2Name);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label Key2Name;
        private Label label1;
        private Button Key1;
    }
}
