namespace Zombie_gampeplay_work
{
    partial class Settings
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(326, 28);
            label1.Name = "label1";
            label1.Size = new Size(212, 60);
            label1.TabIndex = 0;
            label1.Text = "SETTINGS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(346, 117);
            button1.Name = "button1";
            button1.Size = new Size(178, 91);
            button1.TabIndex = 1;
            button1.Text = "CUSTOMIZATION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CustomizationGame;
            // 
            // button2
            // 
            button2.BackColor = Color.Olive;
            button2.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(346, 229);
            button2.Name = "button2";
            button2.Size = new Size(178, 91);
            button2.TabIndex = 2;
            button2.Text = "GAME INSTRUCTIONS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += GameInstructions;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 0);
            button3.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(346, 343);
            button3.Name = "button3";
            button3.Size = new Size(178, 91);
            button3.TabIndex = 3;
            button3.Text = "BACK TO MAIN MENU";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BackMenu;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(875, 472);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Form3_Load;
            KeyDown += KeyIsDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}