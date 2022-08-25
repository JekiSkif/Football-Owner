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
        AttackPlayer [] attacks_arr;
        DefenderPlayer[] defenders_arr;
        MidfilderPlayer[] midfilders_arr;
        GoalKepperPlayer[] goalKeppers_arr;
        public Graphics g;
        bool enable_click_on_market = false;


        public MarketPlace()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
        }
        private void MarketPlace_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button1);
            attacks_arr = new AttackPlayer[2];
            attacks_arr[0] = new AttackPlayer("lionel", "messi", 'm',
                new Date(15, 6, 1991), 96, 10000, 'r', 22222, "PSG", 2, 170, 76,
                Image.FromFile("ATT Antonie Griezmann - Image.png"), 97, 66, 88);
            attacks_arr[0].SetX(1070);
            attacks_arr[0].SetY(210);
            attacks_arr[0].draw();
            enable_click_on_market = true;

        }

        private void MarketPlace_MouseClick(object sender, MouseEventArgs e)
        {
            if (enable_click_on_market == true)
            {
                if (attacks_arr[0].Inside(e.X, e.Y))
                {
                    MessageBox.Show("(" + e.X + ", " + e.Y + ")");
                    g.DrawRectangle(new Pen(Color.Green), attacks_arr[0].GetX(), attacks_arr[0].GetY()
                        , 90, 90);
                }
            }

        }
    }
}
