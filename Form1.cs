using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 5 ; // default gravity speed defined with an integer
        int score = 0; // default score integer set to 0
        // variable ends
       
       

        public Form1()
        {
            InitializeComponent();
        }

      

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flayingbird.Top += gravity;
            flayingbottom.Left -= pipeSpeed;
            flayingtop.Left -= pipeSpeed;
            label2.Text = "Score:" + score;

            if (flayingbottom.Left < -150)
            {
                flayingbottom.Left = 200;
                score++;
            }
            if (flayingtop.Left < -180)
            {
                flayingtop.Left = 300;
                score++;
            }
            if (flayingbird.Bounds.IntersectsWith(flayingbottom.Bounds)|| flayingbird.Bounds.IntersectsWith(flayingtop.Bounds) || flayingbird.Bounds.IntersectsWith(ground.Bounds) || flayingbird.Top < -5)
            {
                endGame();
            }
            if (score > 6)
            {
                pipeSpeed = 15;
            }
            if (score>50)
            {
                pipeSpeed = 30;
            }
            if (score>100)
            {
                pipeSpeed = 40;
            }
           
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameskeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            label2.Text += "Game Over!!!!";
        }
        private void beginGame()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flayingbird_Click(object sender, EventArgs e)
        {

        }
    }
}
