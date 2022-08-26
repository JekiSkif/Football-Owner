using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Football_Owner
{
    class Market
    {
        AttackPlayer[] _attacks_arr;
        DefenderPlayer[] _defenders_arr;
        MidfilderPlayer[] _midfilders_arr;
        GoalKepperPlayer[] _goalKeppers_arr;
        Player[] _my_team;
        int []_temp_my_team;
        static int SIZE = 7;


       public Market()
        {
            int i;
            _goalKeppers_arr = new GoalKepperPlayer[SIZE];
            _defenders_arr = new DefenderPlayer[SIZE];
            _midfilders_arr = new MidfilderPlayer[SIZE];
            _attacks_arr = new AttackPlayer[SIZE];
            _my_team = new Player[SIZE];
            _temp_my_team = new int[SIZE];
            for (i = 0; i < SIZE; i++)
                _my_team[i] = null;
        }

        public void insertGoalKeepers()
        {
            int i, x = 160, y = 210;
            for (i = 0; i < SIZE; i++)
            {
                _goalKeppers_arr[i] = new GoalKepperPlayer(Image.FromFile("GK-Player" + ((i + 1).ToString()) + ".png"));
                _goalKeppers_arr[i].SetX(x);
                _goalKeppers_arr[i].SetY(y);
                _goalKeppers_arr[i].draw();
                y += 100;
            }
        }
        public void insertDefenders()
        {
            int i, x = 485, y = 210;
            for (i = 0; i < SIZE; i++)
            {
                _defenders_arr[i] = new DefenderPlayer(Image.FromFile("DEF-Player" + ((i + 1).ToString()) + ".png"));
                _defenders_arr[i].SetX(x);
                _defenders_arr[i].SetY(y);
                _defenders_arr[i].draw();
                y += 100;
            }
        }
        public void insertMidfilders()
        {
            int i, x = 775, y = 210;
            for (i = 0; i < SIZE; i++)
            {
                _midfilders_arr[i] = new MidfilderPlayer(Image.FromFile("MID-Player" + ((i + 1).ToString()) + ".png"));
                _midfilders_arr[i].SetX(x);
                _midfilders_arr[i].SetY(y);
                _midfilders_arr[i].draw();
                y += 100;
            }
        }
        public void insertAttackers()
        {
            int i, x = 1070, y = 210;
            for (i = 0; i < SIZE; i++)
            {
                _attacks_arr[i] = new AttackPlayer(Image.FromFile("ATT-Player" + ((i + 1).ToString()) + ".png"));
                _attacks_arr[i].SetX(x);
                _attacks_arr[i].SetY(y);
                _attacks_arr[i].draw();
                y += 100;
            }
        }

        public GoalKepperPlayer[] getGoalKeppersArr() { return this._goalKeppers_arr; }
        public DefenderPlayer[] getDefendersArr() { return this._defenders_arr; }
        public MidfilderPlayer[] getMidfildersArr() { return this._midfilders_arr; }
        public AttackPlayer[] getAttacksArr() { return this._attacks_arr; }

        public void isClickOnGK(int x, int y)
        {
            int i;
            GoalKepperPlayer temp = null;
            for (i = 0; i < SIZE; i++)
            {
                if (_goalKeppers_arr[i].Inside(x, y) == true)
                {

                    if (_my_team[0] == null)
                    {
                        temp = _goalKeppers_arr[i];
                        _my_team[0] = temp;
                        _my_team[0].SetY(210);
                        _my_team[0].SetX(1530);
                        _my_team[0].draw();
                        _temp_my_team[0] = i;
                    }
                    else
                    {
                        _goalKeppers_arr[_temp_my_team[0]].draw();
                        MessageBox.Show("(" + this._goalKeppers_arr[i].GetX() + ", " +
                            this._goalKeppers_arr[i].GetY() + ")");

                    }
                }
            }
        }

        public bool isClickOnDEF(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_defenders_arr[i].Inside(x, y) == true)
                    return true;
            }
            return false;
        }
        public bool isClickOnMID(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_midfilders_arr[i].Inside(x, y) == true)
                    return true;
            }
            return false;
        }

        public bool isClickOnATT(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_attacks_arr[i].Inside(x, y) == true)
                    return true;
            }
            return false;
        }
    }
}
