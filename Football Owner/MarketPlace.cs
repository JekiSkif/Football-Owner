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
        }

        private void MarketPlace_MouseClick(object sender, MouseEventArgs e)
        {
            if (enable_click_on_market == true)
            {
                if(_finish_click == false)
                {
                    // if(m.isClickOnGK(e.X,e.Y) || m.isClickOnDEF(e.X,e.Y)
                    //    ||m.isClickOnMID(e.X,e.Y) || m.isClickOnATT(e.X, e.Y))
                    // {
                    // g.DrawRectangle(new Pen(Color.Green), e.X, e.Y
                    //, 90, 90);
                    m.isClickOnGK(e.X, e.Y);
                   // MessageBox.Show("(" + e.X + ", " + e.Y + ")");
                    //}
                }
            }

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            _finish_click = true;
        }
    }
}
