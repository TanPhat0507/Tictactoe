using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms;
using tictactoe3;

namespace Tic_Tac_Toe
{
    public class Chessboardmanager
    {
        #region Properties

        private Panel chessboard; // panel in chessboard

        public Panel ChessBoard
        {
            get { return chessboard; }
            set { chessboard = value; }
        }

        private List<Player> player;  // 
        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        private int currentplayer;// the current player marks

        public int CurrentPlayer
        {
            get { return currentplayer; }
            set { currentplayer = value; }
        }
        private PictureBox pictureBoxturn; // the image in the turn
        public PictureBox PictureBoxTurn
        {
            get { return pictureBoxturn; }
            set { pictureBoxturn = value; }
        }
        private Label labelplayer; // the text in player 1's score
        public Label LabelPlayer
        {
            get { return labelplayer; }
            set { labelplayer = value; }
        }
        private Label labelrobot; // the text in player 2's score
        public Label LabelRobot
        {
            get { return labelrobot; }
            set { labelrobot = value; }
        }
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private event EventHandler playerMarked;// Notify:player clicked
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame; // Notify:end game
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion

        #region Initialize

        public Chessboardmanager(Panel chessboard, PictureBox pictureBoxturn, Label labelplayer, Label labelrobot )
        {
            this.chessboard = chessboard;
            this.PictureBoxTurn = pictureBoxturn;
            this.LabelPlayer = labelplayer;
            this.LabelRobot = labelrobot;
            this.Player = new List<Player>()
            {
                new Player("1",Image.FromFile(Application.StartupPath + "\\Resources\\3515278.png")), // show the "X" in the chessboard
                new Player("2", Image.FromFile(Application.StartupPath + "\\Resources\\1998595.png")) // show the "O" in the chessboard
            };

        }

        #endregion

        #region Methods
        public void draw_chess_board() // draw the buttons in chessboard
        {
            ChessBoard.Enabled = true; // open the chessboard in order that players can mark
            ChessBoard.Controls.Clear(); // remove all the point that players marked (replay)
            CurrentPlayer = 0;

            ChangePlayer();
            Matrix = new List<List<Button>>();

            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.chess_board_height; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.chess_board_width; j++)
                {

                    Button btn = new Button()
                    {
                        Width = Cons.chess_width,
                        Height = Cons.chess_height,
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldbutton = btn;
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + Cons.chess_height);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
        }

        int flag; // flag =0 (player "0" mark) 
        int score1 = 0; // player 1's score
        int score2 = 0; // player 2's score
        int dem = 0; // the number point that players marked

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            dem++;
            if (btn.BackgroundImage != null) { return; }
            Mark(btn);
            ChangePlayer();
            if (playerMarked != null)
                playerMarked(this, new EventArgs());

            if (isEndGame(btn))
            {
                if (flag == 0)
                {
                    EndGame();
                    MessageBox.Show("O won");
                    score2++;
                    labelrobot.Text = "Score: " + score2;
                    dem = 0;

                }

                else
                {
                    EndGame();
                    MessageBox.Show("X won");
                    score1++;
                    labelplayer.Text = "Score: " + score1;
                    dem = 0;
                }

            }
            else if (dem == 9)
            {
                EndGame();
                DrawGame();
                dem = 0;
            }
        }

        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());

        }
        private void DrawGame()
        {
            MessageBox.Show("Draw!");

        }

        private bool isEndGame(Button btn)
        {
            //if return true => Endgame
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.chess_board_width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 3;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.chess_board_height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 3;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cons.chess_board_height || point.X + i >= Cons.chess_board_width)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 3;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.chess_board_width || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cons.chess_board_height || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 3;
        }
        private void Mark(Button btn) // change X->0 or O->X
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            if (currentplayer == 0) flag = 0;
            else flag = 1;
        }
        private void ChangePlayer() // when change players, the image in turn changes
        {
            PictureBoxTurn.Image = Player[CurrentPlayer].Mark;
        }

        #endregion
    }
}