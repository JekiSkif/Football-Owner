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
        public static Player[] _my_team;
        int []_temp_my_team;
        int[] _tempX;
        int[] _tempY;
        static int SIZE = 7;
        static int SIZE_TEAM = 4;

       public Market()
        {
            int i;
            _goalKeppers_arr = new GoalKepperPlayer[SIZE];
            _defenders_arr = new DefenderPlayer[SIZE];
            _midfilders_arr = new MidfilderPlayer[SIZE];
            _attacks_arr = new AttackPlayer[SIZE];
            _my_team = new Player[SIZE_TEAM];
            _temp_my_team = new int[SIZE];
            for (i = 0; i < SIZE_TEAM; i++)
                _my_team[i] = null;
            _tempX = new int[SIZE];
            _tempY = new int[SIZE];
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
        public Player[] getMyTeam() { return _my_team; }

        public void setMyteam(Player[] mt)
        {
            _my_team = mt;
        }

        public void swap(Player p, Player[] arr, int index, int x, int y, int i)
        {
            if (_my_team[index] == null)
            {
                _tempX[index] = p.GetX();
                _tempY[index] = p.GetY();
                _my_team[index] = p;
                _my_team[index].SetX(x);
                _my_team[index].SetY(y);
                _my_team[index].draw();
                _temp_my_team[index] = i;
            }
            else
            {
                arr[_temp_my_team[index]].SetX(_tempX[index]);
                arr[_temp_my_team[index]].SetY(_tempY[index]);
                arr[_temp_my_team[index]].draw();
                _tempX[index] = arr[i].GetX();
                _tempY[index] = arr[i].GetY();
                _my_team[index] = arr[i];
                _my_team[index].SetX(x);
                _my_team[index].SetY(y);
                _my_team[index].draw();
                _temp_my_team[index] = i;
            }
        }
        public void isClickOnGK(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_goalKeppers_arr[i].Inside(x, y) == true)
                {

                    swap(_goalKeppers_arr[i], _goalKeppers_arr, 0, 1530, 210, i);
/*
                    if (_my_team[0] == null)
                    {
                        _tempX[0] = _goalKeppers_arr[i].GetX();
                        _tempY[0] = _goalKeppers_arr[i].GetY();
                        _my_team[0] = _goalKeppers_arr[i];
                        _my_team[0].SetY(210);
                        _my_team[0].SetX(1530);
                        _my_team[0].draw();
                        _temp_my_team[0] = i;
                    }
                    else
                    {
                        //MessageBox.Show("(" + this._goalKeppers_arr[i].GetX() + ", " +
                        //  this._goalKeppers_arr[i].GetY() + ")");
                        _goalKeppers_arr[_temp_my_team[0]].SetX(_tempX[0]);
                        _goalKeppers_arr[_temp_my_team[0]].SetY(_tempY[0]);
                        _goalKeppers_arr[_temp_my_team[0]].draw();
                        _tempX[0] = _goalKeppers_arr[i].GetX();
                        _tempY[0] = _goalKeppers_arr[i].GetY();
                        _my_team[0] = _goalKeppers_arr[i];
                        _my_team[0].SetY(210);
                        _my_team[0].SetX(1530);
                        _my_team[0].draw();
                        _temp_my_team[0] = i;
                    }*/
                }
            }
        }
        public void isClickOnDEF(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
                if (_defenders_arr[i].Inside(x, y) == true)
                    swap(_defenders_arr[i], _defenders_arr, 1, 1530, 310, i);  
        }
        public void isClickOnMID(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
                if (_midfilders_arr[i].Inside(x, y) == true)
                    swap(_midfilders_arr[i], _midfilders_arr, 2, 1530, 410, i);
        }
        public void isClickOnATT(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
                if (_attacks_arr[i].Inside(x, y) == true)
                    swap(_attacks_arr[i], _attacks_arr, 3, 1530, 510, i);
        }

        public bool isMyTeamSelected()
        {
            int i;
            for(i = 0; i < SIZE_TEAM; i++)
                if(_my_team[i] == null)
                    return false;
            return true;
        }

    }
}
