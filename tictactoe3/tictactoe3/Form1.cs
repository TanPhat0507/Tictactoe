using System.Media;
using Tic_Tac_Toe;


namespace tictactoe3
{
    public partial class Form1 : Form
    {
        private void LoopMusic()  //music background
        {
            string musicFilePath = Application.StartupPath + "\\BGM.wav";
            SoundPlayer BGMusic = new SoundPlayer(musicFilePath);
            BGMusic.PlayLooping();
        }
        #region Properties
        Chessboardmanager chessboard;
        #endregion
        public Form1()
        {

            InitializeComponent();
            chessboard = new Chessboardmanager(pannelchessboard, pictureBoxturn, labelplayer, labelrobot/*, textBoxplayer, textBoxrobot*/);

            chessboard.EndedGame += ChessBoard_EndedGame;
            chessboard.PlayerMarked += ChessBoard_PlayerMarked;

            progressBarplayer.Step = Cons.cool_down_step;
            progressBarplayer.Maximum = Cons.cool_down_time;
            progressBarplayer.Value = 0;
            timer1.Interval = Cons.cool_down_interval;



            chessboard.draw_chess_board();
            LoopMusic();

        }
        #region Methods
        void EndGame()
        {
            timer1.Stop();
            pannelchessboard.Enabled = false;
        }
        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timer1.Start();
            progressBarplayer.Value = 0;
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }
        private void timerplayer(object sender, EventArgs e)
        {
            progressBarplayer.PerformStep();
            if (progressBarplayer.Value >= progressBarplayer.Maximum)
            {
                timer1.Stop();
                pannelchessboard.Enabled = false;
                MessageBox.Show("End game!");
            }
        }
        void resetgame()
        {
            Application.Restart();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetgame();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }
        void replay()
        {
            chessboard.draw_chess_board();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            replay();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxrobot_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelinformation_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBoxplayer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBoxplayer_TextChanged(object sender, EventArgs e)
        {
        }

        private void progressBarrobot_Click(object sender, EventArgs e)
        {
        }

        private void progressBarplayer_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxrobottick_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxrobot_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxplayertick_Click(object sender, EventArgs e)
        {
        }

        private void paneloption_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Help_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelplayer2_Click(object sender, EventArgs e)
        {

        }

        private void labelplayer1_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}