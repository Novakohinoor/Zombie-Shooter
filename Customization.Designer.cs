namespace Zombie_gampeplay_work
{
    partial class Customization
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSeaGreen;
            pictureBox1.Image = Properties.Resources.Up5;
            pictureBox1.Location = new Point(209, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ChooseCustomPlayer;
            // 
            // button1
            // 
            button1.Location = new Point(368, 296);
            button1.Name = "button1";
            button1.Size = new Size(197, 34);
            button1.TabIndex = 1;
            button1.Text = "Go to main game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightSeaGreen;
            pictureBox2.Image = Properties.Resources.up;
            pictureBox2.Location = new Point(588, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 32);
            label1.Name = "label1";
            label1.Size = new Size(870, 38);
            label1.TabIndex = 3;
            label1.Text = "CLICK ON THE CHARACTER THAN YOU WANT TO CUSTOMIZE";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(368, 359);
            button2.Name = "button2";
            button2.Size = new Size(197, 32);
            button2.TabIndex = 4;
            button2.Text = "Go to Settings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightSeaGreen;
            pictureBox3.Image = Properties.Resources.up6;
            pictureBox3.Location = new Point(415, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Customization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(939, 450);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Customization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox3;
    }
}