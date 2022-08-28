using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{
    public partial class Play_Form : Form
    {
        public Play_Form()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            MarketPlace mp = new MarketPlace();
            mp.Show();
        }
    }
}
