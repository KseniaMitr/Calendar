using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Calendar_
{
    public partial class calendarForm : Form
    {
        public calendarForm()
        {
            InitializeComponent();
        }

        MyDate myDate = new MyDate();

        private void CalendarForm_Load(object sender, EventArgs e)
        {          
            for (int i = 0; i < 12; i++)
                monthBox.Items.Add((i+1).ToString());            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthBox_TextChanged(object sender, EventArgs e)
        {
            //проверка на количество дней в месяце
            dayBox.Items.Clear();
            myDate.Month = Convert.ToInt32(monthBox.Text);
            for (int i = 0; i < myDate.getCurrentDays(myDate.Month, myDate.Year); i++)
             dayBox.Items.Add((i + 1).ToString());
        }     

        private void today_Click(object sender, EventArgs e)
        {
            DateTime dateToday = DateTime.Today;           
            myDate.setDate(Convert.ToInt32(dateToday.Day), Convert.ToInt32(dateToday.Month), Convert.ToInt32(dateToday.Year));

            dayBox.Text = myDate.Day.ToString();
            monthBox.Text = myDate.Month.ToString();
            yearBox.Text = myDate.Year.ToString();
        }        

       public void onlyNumbers (KeyPressEventArgs e)
        {           
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
            if (e.KeyChar == 13)
            {
                if (Convert.ToInt32(yearBox.Text) > 2100 || Convert.ToInt32(yearBox.Text) < 1600)
                    fail.Text = "введите верный год";
                else fail.Text = "";
            }
        }

        private void monthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                onlyNumbers(e);
                if (Convert.ToInt32(monthBox.Text) > 12 || Convert.ToInt32(monthBox.Text) < 1)
                    fail.Text = "введите верный месяц";
                else fail.Text = "";
            }
        }

        private void dayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                onlyNumbers(e);
                if (Convert.ToInt32(dayBox.Text) > 31 || Convert.ToInt32(dayBox.Text) < 1)
                    fail.Text = "введите верный день";
                else fail.Text = "";
            }
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            myDate.Day = Convert.ToInt32(dayBox.Text);
            myDate.Month = Convert.ToInt32(monthBox.Text);
            myDate.Year = Convert.ToInt32(yearBox.Text);
            myDate.nextData();
            DataOf();
        }

        private void previousDayButton_Click(object sender, EventArgs e)
        {
            myDate.Day = Convert.ToInt32(dayBox.Text);
            myDate.Month = Convert.ToInt32(monthBox.Text);
            myDate.Year = Convert.ToInt32(yearBox.Text);
            myDate.previousData();
            DataOf();            
        }        

        public void DataOf()
        {
            dayBox.Text = myDate.Day.ToString();
            monthBox.Text = myDate.Month.ToString();
            yearBox.Text = myDate.Year.ToString();
        }
    }
}
