using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Owner
{
    class Market
    {
        AttackPlayer[] _attacks_arr;
        DefenderPlayer[] _defenders_arr;
        MidfilderPlayer[] _midfilders_arr;
        GoalKepperPlayer[] _goalKeppers_arr;
        static int SIZE = 5;

       public Market()
        {
            _goalKeppers_arr = new GoalKepperPlayer[11];
            _defenders_arr = new DefenderPlayer[11];
            _midfilders_arr = new MidfilderPlayer[11];
            _attacks_arr = new AttackPlayer[11];

        }

        public void insertGoalKeepers()
        {

        }
        public void insertDefenders()
        {

        }
        public void insertMidfilders()
        {

        }
        public void insertAttackers()
        {

        }
    }
}
