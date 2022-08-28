using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{
    class Manager : Person
    {
        private int _seniority;
        private int _financial_capital;
        private int _salary;
        private string _football_club;

        public Manager(string first_name, string last_name, char gender
            , int age, Date birthday, int seniority, int financial_capital, int salary, 
            string football_club) : base(first_name, last_name, gender, birthday)
        {
            this._seniority = seniority;
            this._financial_capital = financial_capital;
            this._salary = salary;
            this._football_club = football_club;
        }

        public int getSeniority() { return this._seniority; }
        public int getFinancialCapital() { return this._financial_capital; }
        public int getSalary() { return this._salary; }
        public string getFootballClub() { return this._football_club; }

        public void setSeniority(int seniority) { this._seniority = seniority; }
        public void setFinancialCapital(int financial_capital) { this._financial_capital = financial_capital; }
        public void setSalary(int salary) { this._salary = salary; }
        public void setFootballClub(string football_club) { this._football_club = football_club; }

        public string dataManager()
        {
            return "Manager Card :\n\n" +
                "First Name: " + getFirstName() + "\n" +
                "Last Name: " + getLastName() + "\n" +
                "Gender: " + getGender() + "\n" +
                "Age: " + getAge() + "\n" +
                "Football Club: " + _football_club + "\n" +
                "Seniority: " + _seniority + "/n" +
                "Financial Capital: " + _financial_capital + "\n";
        }

        public override void special_ability()
        {
            MessageBox.Show("Go Go Go !!");
        }


    }
}
