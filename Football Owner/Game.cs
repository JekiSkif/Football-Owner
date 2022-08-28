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
        //Player[] _my_team_final;
        public Game()
        {
            InitializeComponent();
           
        }

        private void Game_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
            Market._my_team[0].GetX().ToString());
        }

    }
}
