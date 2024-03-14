namespace tictactoe3
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
            pannelchessboard = new Panel();
            textBoxrobot = new TextBox();
            textBoxplayer = new TextBox();
            progressBarrobot = new ProgressBar();
            progressBarplayer = new ProgressBar();
            pictureBoxrobottick = new PictureBox();
            pictureBoxrobot = new PictureBox();
            pictureBoxplayertick = new PictureBox();
            pictureBoxplayer = new PictureBox();
            panel1 = new Panel();
            labelplayer = new Label();
            panel2 = new Panel();
            labelrobot = new Label();
            menuStrip1 = new MenuStrip();
            Menu = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            pageSetupDialog1 = new PageSetupDialog();
            label3 = new Label();
            label4 = new Label();
            pictureBoxturn = new PictureBox();
            label1 = new Label();
            Replay = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobottick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayertick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayer).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxturn).BeginInit();
            SuspendLayout();
            // 
            // pannelchessboard
            // 
            pannelchessboard.BackColor = Color.Ivory;
            pannelchessboard.BorderStyle = BorderStyle.FixedSingle;
            pannelchessboard.Location = new Point(250, 113);
            pannelchessboard.Name = "pannelchessboard";
            pannelchessboard.Size = new Size(301, 300);
            pannelchessboard.TabIndex = 0;
            pannelchessboard.Paint += panel1_Paint;
            // 
            // textBoxrobot
            // 
            textBoxrobot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxrobot.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxrobot.Location = new Point(73, 33);
            textBoxrobot.Name = "textBoxrobot";
            textBoxrobot.Size = new Size(85, 28);
            textBoxrobot.TabIndex = 9;
            textBoxrobot.TextAlign = HorizontalAlignment.Center;
            textBoxrobot.TextChanged += textBoxrobot_TextChanged;
            // 
            // textBoxplayer
            // 
            textBoxplayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxplayer.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxplayer.Location = new Point(21, 43);
            textBoxplayer.Name = "textBoxplayer";
            textBoxplayer.Size = new Size(85, 28);
            textBoxplayer.TabIndex = 8;
            textBoxplayer.TextAlign = HorizontalAlignment.Center;
            textBoxplayer.TextChanged += textBoxplayer_TextChanged;
            // 
            // progressBarrobot
            // 
            progressBarrobot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBarrobot.Location = new Point(73, 67);
            progressBarrobot.Name = "progressBarrobot";
            progressBarrobot.Size = new Size(0, 36);
            progressBarrobot.TabIndex = 7;
            progressBarrobot.Click += progressBarrobot_Click;
            // 
            // progressBarplayer
            // 
            progressBarplayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBarplayer.Location = new Point(250, 416);
            progressBarplayer.Name = "progressBarplayer";
            progressBarplayer.Size = new Size(301, 32);
            progressBarplayer.TabIndex = 6;
            progressBarplayer.Click += progressBarplayer_Click;
            // 
            // pictureBoxrobottick
            // 
            pictureBoxrobottick.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxrobottick.Image = Properties.Resources._1998595;
            pictureBoxrobottick.Location = new Point(22, 90);
            pictureBoxrobottick.Name = "pictureBoxrobottick";
            pictureBoxrobottick.Size = new Size(32, 32);
            pictureBoxrobottick.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxrobottick.TabIndex = 5;
            pictureBoxrobottick.TabStop = false;
            pictureBoxrobottick.Click += pictureBoxrobottick_Click;
            // 
            // pictureBoxrobot
            // 
            pictureBoxrobot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxrobot.Image = Properties.Resources._2062361_200__1_;
            pictureBoxrobot.Location = new Point(13, 34);
            pictureBoxrobot.Name = "pictureBoxrobot";
            pictureBoxrobot.Size = new Size(50, 50);
            pictureBoxrobot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxrobot.TabIndex = 4;
            pictureBoxrobot.TabStop = false;
            pictureBoxrobot.Click += pictureBoxrobot_Click;
            // 
            // pictureBoxplayertick
            // 
            pictureBoxplayertick.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxplayertick.Image = Properties.Resources._3515278;
            pictureBoxplayertick.Location = new Point(136, 90);
            pictureBoxplayertick.Name = "pictureBoxplayertick";
            pictureBoxplayertick.Size = new Size(30, 30);
            pictureBoxplayertick.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxplayertick.TabIndex = 2;
            pictureBoxplayertick.TabStop = false;
            pictureBoxplayertick.Click += pictureBoxplayertick_Click;
            // 
            // pictureBoxplayer
            // 
            pictureBoxplayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxplayer.Image = Properties.Resources._2062361_200__1_;
            pictureBoxplayer.Location = new Point(127, 34);
            pictureBoxplayer.Name = "pictureBoxplayer";
            pictureBoxplayer.Size = new Size(50, 50);
            pictureBoxplayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxplayer.TabIndex = 1;
            pictureBoxplayer.TabStop = false;
            pictureBoxplayer.Click += pictureBoxplayer_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.AliceBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelplayer);
            panel1.Controls.Add(pictureBoxplayer);
            panel1.Controls.Add(textBoxplayer);
            panel1.Controls.Add(pictureBoxplayertick);
            panel1.Location = new Point(57, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 364);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint_1;
            // 
            // labelplayer
            // 
            labelplayer.AutoSize = true;
            labelplayer.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelplayer.Location = new Point(25, 85);
            labelplayer.Name = "labelplayer";
            labelplayer.Size = new Size(93, 29);
            labelplayer.TabIndex = 9;
            labelplayer.Text = "Score: 0";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Snow;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelrobot);
            panel2.Controls.Add(progressBarrobot);
            panel2.Controls.Add(textBoxrobot);
            panel2.Controls.Add(pictureBoxrobot);
            panel2.Controls.Add(pictureBoxrobottick);
            panel2.Cursor = Cursors.Cross;
            panel2.Location = new Point(557, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 364);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // labelrobot
            // 
            labelrobot.AutoSize = true;
            labelrobot.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelrobot.Location = new Point(73, 85);
            labelrobot.Name = "labelrobot";
            labelrobot.Size = new Size(93, 29);
            labelrobot.TabIndex = 10;
            labelrobot.Text = "Score: 0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(809, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            Menu.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, Exit });
            Menu.Name = "Menu";
            Menu.Size = new Size(60, 24);
            Menu.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(224, 26);
            newGameToolStripMenuItem.Text = "New game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.ShortcutKeys = Keys.Control | Keys.E;
            Exit.Size = new Size(224, 26);
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // timer1
            // 
            timer1.Tick += timerplayer;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(332, 79);
            label3.Name = "label3";
            label3.Size = new Size(81, 29);
            label3.TabIndex = 0;
            label3.Text = "Player ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(415, 79);
            label4.Name = "label4";
            label4.Size = new Size(80, 29);
            label4.TabIndex = 16;
            label4.Text = "'s turn";
            // 
            // pictureBoxturn
            // 
            pictureBoxturn.Location = new Point(397, 83);
            pictureBoxturn.Name = "pictureBoxturn";
            pictureBoxturn.Size = new Size(24, 24);
            pictureBoxturn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxturn.TabIndex = 17;
            pictureBoxturn.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(280, 28);
            label1.Name = "label1";
            label1.Size = new Size(271, 48);
            label1.TabIndex = 18;
            label1.Text = "TIC TAC TOE ";
            label1.Click += label1_Click_1;
            // 
            // Replay
            // 
            Replay.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Replay.ImageAlign = ContentAlignment.TopCenter;
            Replay.Location = new Point(350, 454);
            Replay.Name = "Replay";
            Replay.Size = new Size(100, 29);
            Replay.TabIndex = 19;
            Replay.Text = "Replay";
            Replay.UseVisualStyleBackColor = true;
            Replay.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 502);
            Controls.Add(Replay);
            Controls.Add(label1);
            Controls.Add(pictureBoxturn);
            Controls.Add(label4);
            Controls.Add(progressBarplayer);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pannelchessboard);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobottick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxrobot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayertick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplayer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pannelchessboard;
        private PictureBox pictureBoxrobot;
        private PictureBox pictureBoxplayertick;
        private PictureBox pictureBoxplayer;
        private TextBox textBoxrobot;
        private TextBox textBoxplayer;
        private ProgressBar progressBarrobot;
        private ProgressBar progressBarplayer;
        private PictureBox pictureBoxrobottick;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu;
        private ToolStripMenuItem Exit;
        private System.Windows.Forms.Timer timer1;
        private PageSetupDialog pageSetupDialog1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxturn;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private Label label1;
        private Label labelplayer;
        private Label labelrobot;
        private Button Replay;
    }
}