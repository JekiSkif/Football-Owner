using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{
    public partial class Game : Form
    {
        int i;
        public Graphics g;
        
        public Game()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
            //int x = 440;
            //for (i = 0; i < Market.SIZE_TEAM; i++)
            //{
                
            //    Market._my_team[i].SetY(30);
            //    Market._my_team[i].SetX(x);
            //    Market._my_team[i].draw();
            //    x += 100;
            //}
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("(" + e.X  + ", " +
              e.Y + ")");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
