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
                var temp = new CodeHogEntities();

                Console.WriteLine("Femlaes they be weird");
                foreach(var wow in temp.Tickets)
                {
                    foreach(var shit in wow.Dependencies)
                    {
                        Console.WriteLine(shit.Ticket);
                        Console.WriteLine(shit.Ticket1);
                    }

                    foreach(var shit in wow.Dependencies1)
                    {
                        Console.WriteLine(shit.Ticket);
                        Console.WriteLine(shit.Ticket1);
                    }

                }
                int Status = 0;
                bool TicketArchieveStatus = false;
                //This should be change, to 
                int Reporter = 1;
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
