using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _Player1 = "Player1";
        string _Player2 = "Player2";


        bool IsFirstPlay()
        {
            if (pictureBox1.Tag.ToString() == pictureBox2.Tag.ToString() &&
                pictureBox3.Tag.ToString() == pictureBox4.Tag.ToString() &&
                pictureBox5.Tag.ToString() == pictureBox6.Tag.ToString() &&
                pictureBox7.Tag.ToString() == pictureBox8.Tag.ToString() &&
                 pictureBox9.Tag.ToString() == "?"
                )
            {
                return true;
            }
            return false;
        }

        bool IsAlreadyChosed(string checkBox)
        {
            if(checkBox == "X" || checkBox == "O")
            {
                return true;
            }

            return  false;

        }

        void CheckWinner()
        {
            if (IsPlayer1Won())
            {
                MessageBox.Show("Game Over", "Finised", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPlayer.Text = "Game Over";
                lblWinner.Text = _Player1;
            }
            else if (IsPlayer2Won())
            {
                MessageBox.Show("Game Over", "Finised", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPlayer.Text = "Game Over";
                lblWinner.Text = _Player2;

            }
            else if (IsDrawResult())
            {
                MessageBox.Show("Game Over", "Finised", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPlayer.Text = "Game Over";
                lblWinner.Text = "Draw";
            }
        }

        bool IsDrawResult()
        {
            if (pictureBox1.Tag.ToString() != "?" && 
                pictureBox2.Tag.ToString() != "?" &&
                pictureBox3.Tag.ToString() != "?" &&
                pictureBox4.Tag.ToString() != "?" &&
                pictureBox5.Tag.ToString() != "?" &&
                pictureBox6.Tag.ToString() != "?" &&
                pictureBox7.Tag.ToString() != "?" &&
                pictureBox8.Tag.ToString() != "?"&&
                 pictureBox9.Tag.ToString()!= "?"
                )
            {
                return true;
            }
            return false;
        }

        bool IsPlayer1Won()
        {
            // horizental check
            if (pictureBox1.Tag.ToString() == "X" && pictureBox2.Tag.ToString() == "X" && pictureBox3.Tag.ToString() == "X")
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox2.BackColor = Color.GreenYellow;
                pictureBox3.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox4.Tag.ToString() == "X" && pictureBox5.Tag.ToString() == "X" && pictureBox6.Tag.ToString() == "X")
            {
                pictureBox4.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox6.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox7.Tag.ToString() == "X" && pictureBox8.Tag.ToString() == "X" && pictureBox9.Tag.ToString() == "X")
            {
                pictureBox7.BackColor = Color.GreenYellow;
                pictureBox8.BackColor = Color.GreenYellow;
                pictureBox9.BackColor = Color.GreenYellow;
                return true;
            }

            // vertical check
            if (pictureBox1.Tag.ToString() == "X" && pictureBox4.Tag.ToString() == "X" && pictureBox7.Tag.ToString() == "X")
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox4.BackColor = Color.GreenYellow;
                pictureBox7.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox2.Tag.ToString() == "X" && pictureBox5.Tag.ToString() == "X" && pictureBox8.Tag.ToString() == "X")
            {
                pictureBox2.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox8.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox3.Tag.ToString() == "X" && pictureBox6.Tag.ToString() == "X" && pictureBox9.Tag.ToString() == "X")
            {
                pictureBox3.BackColor = Color.GreenYellow;
                pictureBox6.BackColor = Color.GreenYellow;
                pictureBox9.BackColor = Color.GreenYellow;
                return true;
            }

            // diagonal check

            if (pictureBox1.Tag.ToString() == "X" && pictureBox5.Tag.ToString() == "X" && pictureBox9.Tag.ToString() == "X")
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox9.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox3.Tag.ToString() == "X" && pictureBox5.Tag.ToString() == "X" && pictureBox7.Tag.ToString() == "X")
            {
                pictureBox3.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox7.BackColor = Color.GreenYellow;
                return true;
            }

            return false;
        }

        bool IsPlayer2Won()
        {
            // horizental check
            if (pictureBox1.Tag.ToString() == "O" && pictureBox2.Tag.ToString() == "O" && pictureBox3.Tag.ToString() == "O")
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox2.BackColor = Color.GreenYellow;
                pictureBox3.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox4.Tag.ToString() == "O" && pictureBox5.Tag.ToString() == "O" && pictureBox6.Tag.ToString() == "O")
            {
                pictureBox4.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox6.BackColor = Color.GreenYellow;

                return true;
            }

            if (pictureBox7.Tag.ToString() == "O" && pictureBox8.Tag.ToString() == "O" && pictureBox9.Tag.ToString() == "O")
            {
                pictureBox7.BackColor = Color.GreenYellow;
                pictureBox8.BackColor = Color.GreenYellow;
                pictureBox9.BackColor = Color.GreenYellow;
                return true;
            }

            // vertical check
            if (pictureBox1.Tag.ToString() == "O" && pictureBox4.Tag.ToString() == "O" && pictureBox7.Tag.ToString() == "O")
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox4.BackColor = Color.GreenYellow;
                pictureBox7.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox2.Tag.ToString() == "O" && pictureBox5.Tag.ToString() == "O" && pictureBox8.Tag.ToString() == "O")
            {
                pictureBox2.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox8.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox3.Tag.ToString() == "O" && pictureBox6.Tag.ToString() == "O" && pictureBox9.Tag.ToString() == "O")
            {
                pictureBox3.BackColor = Color.GreenYellow;
                pictureBox6.BackColor = Color.GreenYellow;
                pictureBox9.BackColor = Color.GreenYellow;
                return true;
            }

            // diagonal check

            if (pictureBox1.Tag.ToString() == "O" && pictureBox5.Tag.ToString() == "O" && pictureBox9.Tag.ToString() == "O")
            {
                pictureBox1.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox9.BackColor = Color.GreenYellow;
                return true;
            }

            if (pictureBox3.Tag.ToString() == "O" && pictureBox5.Tag.ToString() == "O" && pictureBox7.Tag.ToString() == "O")
            {
                pictureBox3.BackColor = Color.GreenYellow;
                pictureBox5.BackColor = Color.GreenYellow;
                pictureBox7.BackColor = Color.GreenYellow;
                return true;
            }

            return false;
        }

        void ResetGame()
        {
            // reset tags
            pictureBox1.Tag = "?";
            pictureBox2.Tag = "?";
            pictureBox3.Tag = "?";
            pictureBox4.Tag = "?";
            pictureBox5.Tag = "?";
            pictureBox6.Tag = "?";
            pictureBox7.Tag = "?";
            pictureBox8.Tag = "?";
            pictureBox9.Tag = "?";
            // reset back color
            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BackColor = Color.Black;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BackColor = Color.Black;
            // reset image
            pictureBox1.Image = Resources.question_mark_96;
            pictureBox2.Image = Resources.question_mark_96;
            pictureBox3.Image = Resources.question_mark_96;
            pictureBox4.Image = Resources.question_mark_96;
            pictureBox5.Image = Resources.question_mark_96;
            pictureBox6.Image = Resources.question_mark_96;
            pictureBox7.Image = Resources.question_mark_96;
            pictureBox8.Image = Resources.question_mark_96;
            pictureBox9.Image = Resources.question_mark_96;

            // reset labels
            lblWinner.Text = "In Progress";
            lblPlayer.Text = _Player1;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox1.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox1.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox1.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox1.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox1.Tag = "O";
            }
            else
            {
                pictureBox1.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox1.Tag = "X";
            }

            CheckWinner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox2.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox2.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox2.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox2.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox2.Tag = "O";
            }
            else
            {
                pictureBox2.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox2.Tag = "X";
            }

            CheckWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox3.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox3.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox3.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox3.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox3.Tag = "O";
            }
            else
            {
                pictureBox3.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox3.Tag = "X";
            }

            CheckWinner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox4.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox4.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox4.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox4.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox4.Tag = "O";
            }
            else
            {
                pictureBox4.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox4.Tag = "X";
            }

            CheckWinner();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox5.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox5.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox5.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lblPlayer.Text.ToString() ==_Player2 )
            {
                pictureBox5.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox5.Tag = "O";
            }
            else
            {
                pictureBox5.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox5.Tag = "X";
            }

            CheckWinner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox6.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox6.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox6.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox6.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox6.Tag = "O";
            }
            else
            {
                pictureBox6.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox6.Tag = "X";
            
            }

            CheckWinner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox7.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox7.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox7.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox7.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox7.Tag = "O";
            }
            else
            {
                pictureBox7.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox7.Tag = "X";
            }

            CheckWinner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox8.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox8.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox8.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox8.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox8.Tag = "O";
            }
            else
            {
                pictureBox8.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox8.Tag = "X";
            }

            CheckWinner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (IsFirstPlay())
            {
                pictureBox9.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox9.Tag = "X";
                return;
            }

            if (IsAlreadyChosed(pictureBox9.Tag.ToString()))
            {
                MessageBox.Show("Box Already Chosed", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lblPlayer.Text.ToString() == _Player2)
            {
                pictureBox9.Image = Resources.O;
                lblPlayer.Text = _Player1;
                pictureBox9.Tag = "O";
            }
            else 
            {
                pictureBox9.Image = Resources.X;
                lblPlayer.Text = _Player2;
                pictureBox9.Tag = "X";
            }

            CheckWinner();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
