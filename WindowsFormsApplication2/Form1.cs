using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HolidayDates1 : Form
    {
        private object cout;
        private bool unique;
        private int temp;
        private int j;

        string ListItems;
        string StartDate;
        string EndDate;
        
        const string BH_DATE = "Date";
        const string BH_DAY = "Day";
        const string BH_EVENT = "Event";


        public HolidayDates1()
        {
            InitializeComponent();

            string ListItems;
            string StartDate;
            string EndDate;

            //UK standerd Bank Holidays list for 2017:
            UKBH.Rows.Add("14 April", "Friday", "Good Friday");
            UKBH.Rows.Add("17 April", "Monday", "Easter Monday");
            UKBH.Rows.Add("1 May", "Monday", "Early May Bank Holiday");
            UKBH.Rows.Add("29 May", "Monday", "Spring Bank Holiday");
            UKBH.Rows.Add("27 August", "Monday", "Summer bank holiday");
            UKBH.Rows.Add("25 December", "Tuesday", "Christmas Day");
            UKBH.Rows.Add("26 December", "Wednesday", "Boxing Day");


        }

        //The Start date picker:
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            string StartDate;
        }

        //The End date picker:
        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            string EndDate;
        }

        //Submit button:
        private void btnSubmit_Click(object sender, EventArgs e)
        {
                 string date = StartDatePicker.Text + "  To  " + EndDatePicker.Text + "  " + textBox1.Text;
                 if (HolidaysList.Items.Contains(date))
                 {
                     MessageBox.Show("Error! The holiday is already created");
                 }
                 else
                 {
                     HolidaysList.Items.Add(date);
                 }
        }


        //Holidays List:
        private void HolidaysList_SelectedIndexChanged(object sender, EventArgs e)
        {
           string ListItems;
            
        }



        //  Bin pictuer button: 
        private void picDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to remove:\n\n " + HolidaysList.SelectedItem + " \n\nFrom the List. Click OK to proceed",
    "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                HolidaysList.Items.Remove(HolidaysList.SelectedItem);
            }
        }

        //The search date picker:
        private void SearchDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        //Search button:
        private void btnSearch_Click(object sender, EventArgs e)
        {
            HolidaysList.SelectedItems.Clear();
            for (int i = HolidaysList.Items.Count - 1; i >= 0; i++)
            {
                if (HolidaysList.Items[i].ToString().Contains(SearchDatePicker.Text))
                {
                    HolidaysList.SetSelected(i, true);
                   MessageBox.Show("Yes, there is a holiday on  " + SearchDatePicker.Text);
                }
                else
                {
                     //HolidaysList.SetSelected(i, false);
                    MessageBox.Show("Sorry! There's not a holiday on  " + SearchDatePicker.Text);
                }
            }
        }

        


        //Exit button:
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}