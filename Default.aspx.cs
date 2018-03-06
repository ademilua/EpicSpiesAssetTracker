using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            spylogoImage.ImageUrl = "epic-spies-logo.jpg";
          
            if(!Page.IsPostBack)
            {

                DateTime myValue = DateTime.Now.Date;
                firstCalendar.SelectedDate = myValue;
                firstCalendar.VisibleDate = firstCalendar.SelectedDate;

                DateTime myValue1 = firstCalendar.SelectedDate.AddDays(14);
                secondCalendar.SelectedDate = myValue1;
                secondCalendar.VisibleDate = secondCalendar.SelectedDate;

                DateTime myValue2 = firstCalendar.SelectedDate.AddDays(21);
                thirdCalendar.SelectedDate = myValue2;
                thirdCalendar.VisibleDate = thirdCalendar.SelectedDate;

            }

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string name = firstTextBox.Text; 
            string Assign = secondTextBox.Text;
            double m = 500.0;
            string minus;

            if (secondCalendar.SelectedDate > thirdCalendar.SelectedDate)
            {
                minus = secondCalendar.SelectedDate.Subtract(thirdCalendar.SelectedDate).TotalDays.ToString();
            }
            else
            {
                minus = thirdCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate).TotalDays.ToString();
            }
            double j = double.Parse(minus);
            double p = m * j;
            if (j > 7)
            {
                p += 1000.0; 
            }

           
            string result = string.Format("Assignment {0} , {1}, is Authorized and the total buget is : {2:C}", name, Assign, p);
            resultLabel.Text = result;

            TimeSpan timeBetweenAssignments = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate);
            
            if(timeBetweenAssignments.TotalDays < 14 || timeBetweenAssignments.TotalDays > 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between" +   "previous assignment and new assignment.";
                DateTime myValue1 = firstCalendar.SelectedDate.AddDays(14);
                secondCalendar.SelectedDate = myValue1;
                secondCalendar.VisibleDate = secondCalendar.SelectedDate;
            }
            } 
    }
}