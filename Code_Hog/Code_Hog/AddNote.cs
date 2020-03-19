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
    public partial class AddNote : Form
    {
        protected string newNote;
        CodeHogEntities codeHogEntities;
        protected int ticketNumber;

        public AddNote(int ticketNum)
        {
            //initialization
            InitializeComponent();
            codeHogEntities = new CodeHogEntities();
            ticketNumber = ticketNum;

            //set the title component labels to the correct text
            ticketNumPrintLabel.Text = ticketNum.ToString(); //sets label for current Ticket Number
            //TODO: Set Label for current Username

        }

        //Adds note
        private void button1_Click(object sender, EventArgs e)
        {
            newNote = noteTextBox.Text;

            //update the ticket entry with the new note text and username
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //TODO: Update notes on the current ticket

                    //TODO: Save Changes to ticket

                }
            }

            //close the form
            this.Close();
        }
    }
}
