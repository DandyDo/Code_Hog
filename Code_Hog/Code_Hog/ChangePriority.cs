using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog
{
    public partial class ChangePriority : Form
    {
        protected int ticketNumber;
        CodeHogEntities codeHogEntities;
        protected int chosenPriority;
        protected bool Lock = false;

        public ChangePriority(int ticketNum)
        {
            InitializeComponent();
            codeHogEntities = new CodeHogEntities();
            ticketNumber = ticketNum;

            //set menu components
            ticketNumPrintLabel.Text = ticketNum.ToString(); //ticket Number label
            //TODO

            //set default radial button to the ticket's current priority
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    switch (ticket.TicketPriority)
                    {
                        case 1:
                            radioButton1.Checked = true;
                            chosenPriority = 1;
                            break;
                        case 2:
                            radioButton2.Checked = true;
                            chosenPriority = 2;
                            break;
                        case 3:
                            radioButton3.Checked = true;
                            chosenPriority = 3;
                            break;
                        case 4:
                            radioButton4.Checked = true;
                            chosenPriority = 4;
                            break;
                        case 5:
                            radioButton5.Checked = true;
                            chosenPriority = 5;
                            break;

                    }

                }

            }

        }

        //radio button handling. If one is pressed, the others are not
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (!Lock)
            {
                chosenPriority = 1;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                Lock = true;

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!Lock)
            {
                chosenPriority = 2;
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                Lock = true;

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!Lock)
            {
                chosenPriority = 3;
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                Lock = true;

            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!Lock)
            {
                chosenPriority = 4;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
                radioButton5.Checked = false;
                Lock = true;

            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (!Lock)
            {
                chosenPriority = 5;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton1.Checked = false;
                Lock = true;

            }

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //update the ticket entry with the new priority
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //Update priority on the current ticket
                    ticket.TicketPriority = chosenPriority;

                    //Save changes to DB
                    codeHogEntities.SaveChanges();

                }
            }

            //close the form
            this.Close();

        }

    }

}
