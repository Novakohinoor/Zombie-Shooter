namespace Zombie_gampeplay_work
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            StartButton = new Button();
            SettingsButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.AutoSize = true;
            StartButton.BackColor = Color.FromArgb(64, 64, 0);
            StartButton.BackgroundImageLayout = ImageLayout.None;
            StartButton.FlatAppearance.BorderColor = Color.White;
            StartButton.FlatAppearance.BorderSize = 2;
            StartButton.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.ForeColor = SystemColors.ButtonHighlight;
            StartButton.Location = new Point(339, 185);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(130, 75);
            StartButton.TabIndex = 0;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartGame;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.Olive;
            SettingsButton.FlatAppearance.BorderColor = Color.Black;
            SettingsButton.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.ForeColor = SystemColors.ButtonFace;
            SettingsButton.Location = new Point(525, 185);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(130, 77);
            SettingsButton.TabIndex = 1;
            SettingsButton.Text = "SETTINGS";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsGame;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkKhaki;
            ExitButton.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = SystemColors.ButtonFace;
            ExitButton.Location = new Point(156, 321);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 78);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Impact", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 54);
            label1.TabIndex = 3;
            label1.Text = "ZOMBIE SEIGE";
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(156, 187);
            button4.Name = "button4";
            button4.Size = new Size(130, 78);
            button4.TabIndex = 4;
            button4.Text = "DIFFICULTY";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGoldenrod;
            button5.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(339, 321);
            button5.Name = "button5";
            button5.Size = new Size(130, 78);
            button5.TabIndex = 5;
            button5.Text = "LOGIN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(525, 321);
            button6.Name = "button6";
            button6.Size = new Size(140, 78);
            button6.TabIndex = 6;
            button6.Text = "LEADERBOARD";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(SettingsButton);
            Controls.Add(StartButton);
            ForeColor = Color.Olive;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button StartButton;
        private Button SettingsButton;
        private Button ExitButton;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}