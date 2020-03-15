﻿using System;
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
            int Pri = -1;
            if (RadioPri1.Checked)
                Pri = 1;
            else if (RadioPri2.Checked)
                Pri = 2;
            else if (RadioPri3.Checked)
                Pri = 3;
            else if (RadioPri4.Checked)
                Pri = 4;
            else if (RadioPri5.Checked)
                Pri = 5;
            if (TextName.TextLength == 0 || TextDesc.TextLength == 0 || Pri == -1)
                MessageBox.Show("Bro this is empty");
            else
            {
                //Setting up the database.
                var Database = new CodeHogEntities();


                //Reporter should be the person who logs in UserId. Just putting a placeholder here for future referecne.
                int Reporter = 1;
                var NewTicket = new Ticket()
                {
                    TicketArchiveStatus = false,
                    TicketStatus = 0,



                    TicketDescription = TextDesc.Name,
                    TicketName = TextName.Text,
                    TicketPriority = Pri,
                TicketReporter = Reporter 
                };

                Database.Tickets.Add(NewTicket);
                Database.SaveChanges();

                // This is the default values of a newly created ticket.
                //var wow=Database.Database.ExecuteSqlCommand("FROM * SELECT *");

            }
        }

        private void ButtonReturnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus Menus = new Menus();
            Menus.Show();
        }

        private void RadioPri1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
