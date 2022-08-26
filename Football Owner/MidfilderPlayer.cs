using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Football_Owner
{
    class MidfilderPlayer : Player
    {
        private int _passing;
        private int _vision;
        public MidfilderPlayer(string first_name, string last_name, char gender
            ,  Date birthday, int rating, int value, char foot,
            int salary, string football_club, int seniority, int height, int weight,Image im, int passing, int vision) : base(first_name, last_name, gender
            ,  birthday, rating, value, foot,
             salary, football_club, seniority, height, weight,im)
        {
            this._passing = passing;
            this._vision = vision;
        }

        public MidfilderPlayer(Image img) : base(img)
        {

        }

        public int getPassing()
        {
            return this._passing;
        }
        public int getVision()
        {
            return this._vision;
        }
        public void setPassing(int passing)
        {
            this._passing = passing;
        }

        public void setVision(int vision)
        {
            this._vision = vision;
        }
        public string dataDefenderPlayer()
        {
            return "Midfielder : " + '\n' + dataPlayer() + "Passing:" + _passing
                + '\n' + "Vision:" + _vision;

        }

        public override void special_ability()
        {
            MessageBox.Show("What a pass !!");
        }
    }
}