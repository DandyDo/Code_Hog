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

                foreach(Ticket temp in Database.Tickets)
                {
                    Console.WriteLine("ID " + temp.TicketID);
                }


                var Smash = Database.Tickets.ElementAt(0);
                var SMash = new Ticket()
                {
                    TicketArchiveStatus = false,
                    TicketStatus = 0,
                    TicketPriority = 0,

                    TicketDescription = "WOW",
                    TicketName = "Fuck",
                    TicketReporter = 0
                };

                Database.Tickets.Add(Smash);

                // This is the default values of a newly created ticket.
                //var wow=Database.Database.ExecuteSqlCommand("FROM * SELECT *");

                Database.SaveChanges();


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
