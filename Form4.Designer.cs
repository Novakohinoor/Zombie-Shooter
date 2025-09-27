namespace Zombie_gampeplay_work
{
    partial class LeaderBoards
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
            dataGridView1 = new DataGridView();
            PlayerName = new DataGridViewTextBoxColumn();
            Kills = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PlayerName, Kills });
            dataGridView1.Location = new Point(99, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(635, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PlayerName
            // 
            PlayerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PlayerName.DataPropertyName = "PlayerName";
            PlayerName.HeaderText = "Player Name";
            PlayerName.MinimumWidth = 8;
            PlayerName.Name = "PlayerName";
            PlayerName.ReadOnly = true;
            // 
            // Kills
            // 
            Kills.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kills.DataPropertyName = "Kills";
            Kills.HeaderText = "Player Kills";
            Kills.MinimumWidth = 8;
            Kills.Name = "Kills";
            Kills.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(319, 49);
            label1.Name = "label1";
            label1.Size = new Size(202, 38);
            label1.TabIndex = 1;
            label1.Text = "LeaderBoards ";
            // 
            // button1
            // 
            button1.Location = new Point(360, 457);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LeaderBoards
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(819, 538);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "LeaderBoards";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += LeaderBoards_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PlayerName;
        private DataGridViewTextBoxColumn Kills;
        private Label label1;
        private Button button1;
    }
}