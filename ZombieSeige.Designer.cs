namespace Zombie_gampeplay_work
{
    partial class ZombieSeige
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
            components = new System.ComponentModel.Container();
            txtAmmo = new Label();
            txtKills = new Label();
            label3 = new Label();
            HealthBar = new ProgressBar();
            GameTimer = new System.Windows.Forms.Timer(components);
            Player = new PictureBox();
            RestartMessage = new Label();
            ExitGame = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            Start_Timer = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmmo.ForeColor = Color.White;
            txtAmmo.Location = new Point(23, 4);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(138, 38);
            txtAmmo.TabIndex = 0;
            txtAmmo.Text = "Ammo: 0";
            txtAmmo.Click += txtAmmo_Click;
            // 
            // txtKills
            // 
            txtKills.AutoSize = true;
            txtKills.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtKills.ForeColor = Color.White;
            txtKills.Location = new Point(196, 7);
            txtKills.Name = "txtKills";
            txtKills.Size = new Size(103, 38);
            txtKills.TabIndex = 1;
            txtKills.Text = "Kills: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(747, 9);
            label3.Name = "label3";
            label3.Size = new Size(112, 38);
            label3.TabIndex = 2;
            label3.Text = "Health:";
            // 
            // HealthBar
            // 
            HealthBar.BackColor = Color.DarkOliveGreen;
            HealthBar.ForeColor = SystemColors.ActiveCaptionText;
            HealthBar.Location = new Point(865, 7);
            HealthBar.Name = "HealthBar";
            HealthBar.Size = new Size(246, 35);
            HealthBar.TabIndex = 3;
            HealthBar.UseWaitCursor = true;
            HealthBar.Value = 100;
            HealthBar.Click += HealthBar_Click;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // Player
            // 
            Player.Image = Properties.Resources.up;
            Player.Location = new Point(495, 299);
            Player.Name = "Player";
            Player.Size = new Size(66, 100);
            Player.SizeMode = PictureBoxSizeMode.AutoSize;
            Player.TabIndex = 4;
            Player.TabStop = false;
            // 
            // RestartMessage
            // 
            RestartMessage.AutoSize = true;
            RestartMessage.BackColor = Color.White;
            RestartMessage.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            RestartMessage.Location = new Point(12, 50);
            RestartMessage.Name = "RestartMessage";
            RestartMessage.Size = new Size(297, 30);
            RestartMessage.TabIndex = 5;
            RestartMessage.Text = "Please press enter to restart";
            // 
            // ExitGame
            // 
            ExitGame.AutoSize = true;
            ExitGame.BackColor = Color.White;
            ExitGame.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ExitGame.Location = new Point(823, 47);
            ExitGame.Name = "ExitGame";
            ExitGame.Size = new Size(288, 30);
            ExitGame.TabIndex = 6;
            ExitGame.Text = "Or press E to exit the game";
            ExitGame.Click += ExitGame_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkKhaki;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(495, 4);
            label1.Name = "label1";
            label1.Size = new Size(127, 38);
            label1.TabIndex = 7;
            label1.Text = "Pause";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += PauseButton;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkKhaki;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(321, 4);
            label2.Name = "label2";
            label2.Size = new Size(168, 38);
            label2.TabIndex = 8;
            label2.Text = "Main Menu";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkKhaki;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(628, 4);
            label4.Name = "label4";
            label4.Size = new Size(124, 38);
            label4.TabIndex = 9;
            label4.Text = "Settings";
            label4.Click += label4_Click;
            // 
            // Start_Timer
            // 
            Start_Timer.Interval = 1000;
            Start_Timer.Tick += Start_Timer_Tick;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(321, 156);
            label5.Name = "label5";
            label5.Size = new Size(412, 70);
            label5.TabIndex = 10;
            label5.Text = "3";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // ZombieSeige
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1113, 618);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExitGame);
            Controls.Add(RestartMessage);
            Controls.Add(Player);
            Controls.Add(HealthBar);
            Controls.Add(label3);
            Controls.Add(txtKills);
            Controls.Add(txtAmmo);
            Name = "ZombieSeige";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zombie Siege";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAmmo;
        private Label txtKills;
        private Label label3;
        private ProgressBar HealthBar;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox Player;
        private Label RestartMessage;
        private Label ExitGame;
        private Label label1;
        private Label label2;
        private Label label4;
        private System.Windows.Forms.Timer Start_Timer;
        private Label label5;
    }
}