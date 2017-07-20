using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayCalculatorWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Day Settings
            this.Day.AutoSize = false;
            this.Day.Height = 40;
            this.Day.Width = 40;
            //Month Settings
            this.Month.AutoSize = false;
            this.Month.Height = 40;
            this.Month.Width = 40;
            //Year Settings
            this.Year.AutoSize = false;
            this.Year.Height = 40;
            this.Year.Width = 70;
            //Result Settings(Label)
            this.Result.Text = "";
            Result.Left = 200;
        }

        public static int YearCode(int year)
        {
            int yearcode;
            yearcode = (year % 100 + (year % 100) / 4) % 7;
            return yearcode;
        }

        public static int MonthCode(int month)
        {
            int monthcode = -1;
            switch (month)
            {
                case 1:
                case 10:
                    monthcode = 0;
                    break;
                case 2:
                case 3:
                case 11:
                    monthcode = 3;
                    break;
                case 4:
                case 7:
                    monthcode = 6;
                    break;
                case 5:
                    monthcode = 1;
                    break;
                case 6:
                    monthcode = 4;
                    break;
                case 8:
                    monthcode = 2;
                    break;
                case 9:
                case 12:
                    monthcode = 5;
                    break;
            }
            return monthcode;
        }

        public static int CenturyCode(int year)
        {
            int centurycode = -1;
            if (year < 1799)
                centurycode = 4;
            else if (year < 1899)
                centurycode = 2;
            else if (year < 1999)
                centurycode = 0;
            else if (year < 2099)
                centurycode = 6;
            else if (year < 2199)
                centurycode = 4;
            else if (year < 2299)
                centurycode = 2;
            else
                centurycode = 0;
            return centurycode;
        }

        public static int LeapYearCode(int year, int month)
        {
            int leapyearcode = 0;
            if (year % 4 == 0)
            {
                if (month <= 2)
                    leapyearcode = 1;
            }
            return leapyearcode;
        }

        public static bool CheckDay(int day,int year,int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day <= 31 && day > 0)
                        return true;
                    break;
                case 2:
                    if (year % 4 == 0)
                    {
                        if (day <= 29 && day > 0)
                            return true;
                    }
                    else
                    {
                        if (day <= 28 && day > 0)
                            return true;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day <= 30 && day > 0)
                        return true;
                    break;
            }
            return false;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int year, month, day;
            bool GoodDay = false;
            TextBox daytb = (TextBox)Day;
            TextBox monthtb = (TextBox)Month;
            TextBox yeartb = (TextBox)Year;
            int parsedValue;
            if(daytb.TextLength == 0 || monthtb.TextLength == 0 || yeartb.TextLength == 0)
            {
                Result.Text = "Fill the fields";
                Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
            }
            else if (int.TryParse(Day.Text, out parsedValue) && int.TryParse(Month.Text, out parsedValue) && int.TryParse(Year.Text, out parsedValue))
            {
                day = Convert.ToInt32(daytb.Text);
                month = Convert.ToInt32(monthtb.Text);
                year = Convert.ToInt32(yeartb.Text);
                if (year >= 2400 || year < 1700)
                {
                    Result.Text = "Choose year between 1700-2399";
                    Result.Font = new Font(Result.Font.Name, 15, Result.Font.Style, Result.Font.Unit);
                }
                else if (month > 12 || month < 1)
                {
                    Result.Text = "Choose month between 1-12";
                    Result.Font = new Font(Result.Font.Name, 15, Result.Font.Style, Result.Font.Unit);
                }
                else if (!CheckDay(day, year, month))
                {
                    Result.Text = "Choose a correct day";
                    Result.Font = new Font(Result.Font.Name, 15, Result.Font.Style, Result.Font.Unit);
                }
                else
                {
                    int TheDayNumber;
                    TheDayNumber = (YearCode(year) + MonthCode(month) + CenturyCode(year) + day - LeapYearCode(year, month)) % 7;
                    switch (TheDayNumber)
                    {
                        case 0:
                            Result.Text = "Day:Sunday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                        case 1:
                            Result.Text = "Day:Monday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                        case 2:
                            Result.Text = "Day:Tuesday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                        case 3:
                            Result.Text = "Day:Wednesday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                        case 4:
                            Result.Text = "Day:thursday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                        case 5:
                            Result.Text = "Day:Friday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                        case 6:
                            Result.Text = "Day:Saturday";
                            Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
                            break;
                    }
                }

            }
            else
            {
                Result.Text = "Only numbers";
                Result.Font = new Font(Result.Font.Name, 30, Result.Font.Style, Result.Font.Unit);
            }
            
        }
    }
}
