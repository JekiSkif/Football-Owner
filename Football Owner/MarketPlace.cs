using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{

    public partial class MarketPlace : Form
    {
        Market m;
        public Graphics g;
        bool enable_click_on_market = false;
        bool _finish_click = false;

        public MarketPlace()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
            m = new Market();
            this.Controls.Remove(Finish);

        }
        private void MarketPlace_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button1);
            m.insertGoalKeepers();
            m.insertDefenders();
            m.insertMidfilders();
            m.insertAttackers();
            enable_click_on_market = true;
            this.Controls.Add(Finish);
            
        }

        private void MarketPlace_MouseClick(object sender, MouseEventArgs e)
        {
            if (enable_click_on_market == true)
            {
                if(_finish_click == false)
                {
                    m.isClickOnGK(e.X, e.Y);
                    m.isClickOnDEF(e.X, e.Y);
                    m.isClickOnMID(e.X, e.Y);
                    m.isClickOnATT(e.X, e.Y);
                }
            }

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            int x = 440, i;
            string message = "Are you sure this is your selected team? ";
            string title = "Continue";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (!m.isMyTeamSelected())
                MessageBox.Show("Your team is not ready!\nplease finish your selection");
            else
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    _finish_click = true;
                    Game gm = new Game();
                    gm.Show();
                    for (i = 0; i < Market.SIZE_TEAM; i++)
                    {
                        Market._my_team[i].SetY(30);
                        Market._my_team[i].SetX(x);
                        Market._my_team[i].draw();
                        x += 100;
                    }
                   // this.Close();

                }
                else
                {
                    // Do something  
                }
            }
        }
    }
}
