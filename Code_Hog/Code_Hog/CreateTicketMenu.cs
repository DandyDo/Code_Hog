using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog {
    public partial class CreateTicketMenu : Form {
        public CreateTicketMenu() {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateTicketMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeHogDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.codeHogDataSet.Tickets);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNewTicket_Click(object sender, EventArgs e)
        {
            if (TextName.TextLength == 0 || TextDesc.TextLength == 0)
                MessageBox.Show("Bro this is empty");
            else
            {
                //Setting up the database.
                var Database = new CodeHogEntities();

                //Database.Tickets.Add()


                Console.WriteLine("Femlaes they be weird");

                Ticket ticket = new Ticket( );
                
                // This is the default values of a newly created ticket.
                int Status = 0;
                bool TicketArchieveStatus = false;
                //This should be change, depending on the user who logs in. This is their user id.
                int Reporter = 1;

                ticket.TicketArchiveStatus = TicketArchieveStatus;
                ticket.TicketStatus = Status;
                ticket.TicketReporter = Reporter;

                //This is from the textboxes direclty
                ticket.TicketDescription = TextDesc.Text;
                ticket.TicketName = TextName.Text;

                ticket.TicketPriority = 1;

                ticket.TicketID = 5;
                //ticket.TicketID = (Database.Tickets.Count());

                Console.WriteLine(
                    ticket.TicketID + "\n" +
                    ticket.TicketName + "\n"+
                    ticket.TicketDescription + "\n"+

                    ticket.TicketPriority + "\n"+
                    ticket.TicketStatus + "\n"+
                    ticket.TicketReporter + "\n"+
                    ticket.TicketArchiveStatus + "\n"

                    );

                Database.Tickets.Add(ticket);
                //Database.SaveChanges();
            }

        }

        private void ButtonReturnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus Menus = new Menus();
            Menus.Show();
        }
    }
}
