namespace SpaceShip
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MoveBgTimer = new System.Windows.Forms.Timer(components);
            Player = new PictureBox();
            LeftMoveTimer = new System.Windows.Forms.Timer(components);
            RightMoveTimer = new System.Windows.Forms.Timer(components);
            DownMoveTimer = new System.Windows.Forms.Timer(components);
            UpMoveTimer = new System.Windows.Forms.Timer(components);
            MoveMunitionTimer = new System.Windows.Forms.Timer(components);
            MoveEnemiesTimer = new System.Windows.Forms.Timer(components);
            EnemiesMunitionTimer = new System.Windows.Forms.Timer(components);
            PlayBtn = new Button();
            ExitBtn = new Button();
            label = new Label();
            scoretxt = new Label();
            Level = new Label();
            levellbl = new Label();
            scorelbl = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // MoveBgTimer
            // 
            MoveBgTimer.Enabled = true;
            MoveBgTimer.Interval = 10;
            MoveBgTimer.Tick += MoveBgTimer_Tick_1;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(260, 400);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.SizeMode = PictureBoxSizeMode.Zoom;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            LeftMoveTimer.Interval = 5;
            LeftMoveTimer.Tick += LeftMoveTimer_Tick;
            // 
            // RightMoveTimer
            // 
            RightMoveTimer.Interval = 5;
            RightMoveTimer.Tick += RightMoveTimer_Tick;
            // 
            // DownMoveTimer
            // 
            DownMoveTimer.Interval = 5;
            DownMoveTimer.Tick += DownMoveTimer_Tick;
            // 
            // UpMoveTimer
            // 
            UpMoveTimer.Interval = 5;
            UpMoveTimer.Tick += UpMoveTimer_Tick;
            // 
            // MoveMunitionTimer
            // 
            MoveMunitionTimer.Enabled = true;
            MoveMunitionTimer.Interval = 20;
            MoveMunitionTimer.Tick += MoveMunitionTimer_Tick;
            // 
            // MoveEnemiesTimer
            // 
            MoveEnemiesTimer.Enabled = true;
            MoveEnemiesTimer.Tick += MoveEnemiesTimer_Tick;
            // 
            // EnemiesMunitionTimer
            // 
            EnemiesMunitionTimer.Enabled = true;
            EnemiesMunitionTimer.Interval = 20;
            EnemiesMunitionTimer.Tick += EnemiesMunitionTimer_Tick;
            // 
            // PlayBtn
            // 
            PlayBtn.Location = new Point(198, 198);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(180, 61);
            PlayBtn.TabIndex = 1;
            PlayBtn.Text = "Play";
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Visible = false;
            PlayBtn.Click += ReplayBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(198, 285);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(180, 56);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Visible = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Perpetua Titling MT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(198, 140);
            label.Name = "label";
            label.Size = new Size(169, 55);
            label.TabIndex = 3;
            label.Text = "label1";
            label.Visible = false;
            // 
            // scoretxt
            // 
            scoretxt.AutoSize = true;
            scoretxt.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoretxt.ForeColor = SystemColors.ButtonHighlight;
            scoretxt.Location = new Point(12, 9);
            scoretxt.Name = "scoretxt";
            scoretxt.Size = new Size(91, 28);
            scoretxt.TabIndex = 4;
            scoretxt.Text = "Score";
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Level.ForeColor = SystemColors.ButtonHighlight;
            Level.Location = new Point(427, 9);
            Level.Name = "Level";
            Level.Size = new Size(97, 28);
            Level.TabIndex = 5;
            Level.Text = "Level :";
            // 
            // levellbl
            // 
            levellbl.AutoSize = true;
            levellbl.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            levellbl.ForeColor = SystemColors.ButtonHighlight;
            levellbl.Location = new Point(516, 9);
            levellbl.Name = "levellbl";
            levellbl.Size = new Size(44, 28);
            levellbl.TabIndex = 6;
            levellbl.Text = "00";
            // 
            // scorelbl
            // 
            scorelbl.AutoSize = true;
            scorelbl.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scorelbl.ForeColor = SystemColors.ButtonHighlight;
            scorelbl.Location = new Point(109, 9);
            scorelbl.Name = "scorelbl";
            scorelbl.Size = new Size(44, 28);
            scorelbl.TabIndex = 7;
            scorelbl.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(582, 450);
            Controls.Add(scorelbl);
            Controls.Add(levellbl);
            Controls.Add(Level);
            Controls.Add(scoretxt);
            Controls.Add(label);
            Controls.Add(ExitBtn);
            Controls.Add(PlayBtn);
            Controls.Add(Player);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(600, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            KeyDown += Form1_KeyDown_1;
            KeyUp += Form1_KeyUp_1;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private PictureBox Player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private Button PlayBtn;
        private Button ExitBtn;
        private Label label;
        private Label scoretxt;
        private Label Level;
        private Label levellbl;
        private Label scorelbl;
    }
}
