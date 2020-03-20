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
    public partial class ChangeStatus : Form
    {
        protected int ticketNumber;
        CodeHogEntities codeHogEntities;
        protected int choice;

        public ChangeStatus(int TicketNum)
        {
            InitializeComponent();
            codeHogEntities = new CodeHogEntities();
            ticketNumber = TicketNum;

            //set menu components
            ticketNumPrintLabel.Text = TicketNum.ToString(); //ticket Number label
            //TODO

            //Get current ticket status
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //set status label
                    switch (ticket.TicketStatus)
                    {
                        case 1:
                            PrintStatusLabel.Text = "Unresolved";
                            break;
                        case 2:
                            PrintStatusLabel.Text = "Under Review";
                            break;
                        case 3:
                            PrintStatusLabel.Text = "Archived";
                            break;

                    }

                    //set default choice
                    choice = ticket.TicketStatus;

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintStatusLabel.Text = "Unresolved";
            choice = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintStatusLabel.Text = "Under Review";
            choice = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintStatusLabel.Text = "Archived";
            choice = 3;

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //Set new ticket status
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //set status to choice
                    ticket.TicketStatus = choice;

                    //set archive status
                    if (choice < 3)
                    {
                        ticket.TicketArchiveStatus = false;

                    } else
                    {
                        ticket.TicketArchiveStatus = true;

                    }

                }

            }

            //Save changes to DB
            codeHogEntities.SaveChanges(); //TODO FIX Does noot work!!

            //close the form
            this.Close();

        }

    }

}
