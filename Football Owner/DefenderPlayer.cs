using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Football_Owner
{
    class DefenderPlayer : Player
    {

        private int _tackle;
        private int _physicality;
        public DefenderPlayer(string first_name, string last_name, char gender
            ,  Date birthday, int rating, int value, char foot,
            int salary, string football_club, int seniority, int height, int weight,Image im, int tackle, int physicality) : base(first_name, last_name, gender
            ,  birthday, rating, value, foot,
             salary, football_club, seniority, height, weight,im)
        {
            this._tackle = tackle;
            this._physicality = physicality;
        }

        public DefenderPlayer(Image img) : base(img)
        {

        }
        public int getTackle()
        {
            return this._tackle;
        }
        public int getPhysicality()
        {
            return this._physicality;
        }
        public void setTackle(int tackle)
        {
            this._tackle = tackle;
        }

        public void setPhysicality(int physicality)
        {
            this._physicality = physicality;
        }
        public string dataDefenderPlayer()
        {
            return "Defender : " + '\n' + dataPlayer() + "Tackle:" + _tackle
                + '\n' + "Physicality:" + _physicality;

        }

        public override void special_ability()
        {
            MessageBox.Show("Great Tackle !!");
        }
    }
}