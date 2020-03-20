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
    public partial class Menus : Form {

        CodeHogEntities codeHogEntities;
        public bool CurrentSort { get; private set; }
        public int CurrTicket;

        enum ChosenSort {

            TicketSort = 0,
            PrioritySort = 1
        }

        public Menus() {

            InitializeComponent();
            codeHogEntities = new CodeHogEntities();
            CurrentSort = Convert.ToBoolean(ChosenSort.TicketSort);

            ApplyFilterToDataGrid();
        }

        private void Menus_Load(object sender, EventArgs e) {

            // TODO: This line of code loads data into the 'codeHogDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.codeHogDataSet1.Users);
            // TODO: This line of code loads data into the 'codeHogDataSet1.User_Roles' table. You can move, or remove it, as needed.
            this.user_RolesTableAdapter.Fill(this.codeHogDataSet1.User_Roles);
            // TODO: This line of code loads data into the 'codeHogDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.codeHogDataSet.Tickets);
        }

        private void TicketDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

            int TicketId = Convert.ToInt32(ticketDataGridView.Rows[e.RowIndex].Cells[0].Value);
            PrintTicketToLabelsAndTextBoxes(TicketId);
        }

        private void PrintTicketToLabelsAndTextBoxes(int TicketId) {

            foreach (var ticket in codeHogEntities.Tickets) {

                if (ticket.TicketID == TicketId) {

                    ticketIDLabel.Text = ticket.TicketID.ToString();
                    CurrTicket = ticket.TicketID;
                    priorityLabel.Text = ticket.TicketPriority.ToString();
                    statusLabel.Text = ticket.TicketStatus.ToString();

                    foreach (var user in codeHogEntities.Users) {

                        if (user.UserID == ticket.TicketReporter) {

                            reporterNameLabel.Text = user.Username;
                            break;
                        }
                    }

                    nameTextBox.Text = ticket.TicketName;
                    descriptionTextBox.Text = ticket.TicketDescription;
                    noteTextBox.Text = "";

                    foreach (var note in codeHogEntities.Notes) {

                        if (note.TicketID == TicketId) {

                            noteTextBox.Text += $"-({note.User})\n{note.Note1}\n";
                        }
                    }
                }
            }
        }

        private void FilterDataGridChange(object sender, EventArgs e) {

            ApplyFilterToDataGrid();
        }

        private void ApplyFilterToDataGrid() {

            if (archiveCheckBox.Checked && (activeCheckBox.Checked == false)) {

                ticketDataGridView.DataSource = codeHogEntities.Tickets.Where(x => x.TicketArchiveStatus).ToList();
            }
            else if (activeCheckBox.Checked && archiveCheckBox.Checked == false) {

                ticketDataGridView.DataSource = codeHogEntities.Tickets.Where(x => x.TicketArchiveStatus == false).ToList();
            }
            else {
                ticketDataGridView.DataSource = codeHogEntities.Tickets.Where(x => (x.TicketArchiveStatus == false || x.TicketArchiveStatus == true)).ToList();
            }
        }

        private void CreateNewTicketButton_Click(object sender, EventArgs e) {

        }

        private void EditTicketButton_Click(object sender, EventArgs e) {

        }

        private void AddNoteButton_Click(object sender, EventArgs e) {
            //if a ticket is selected, open the add note menu
            if (ticketIDLabel.Text != "..")
            {
                Form m = new AddNote(CurrTicket);
                m.Show();
            } else
            {
                MessageBox.Show("Please select a Ticket before attempting to add a note");
            }

        }

        private void addUserButton_Click(object sender, EventArgs e) {

        }

        private void EditPriorityButton_Click(object sender, EventArgs e)
        {
            //if a ticket is selected, open the changePriority menu
            if (ticketIDLabel.Text != "..")
            {
                Form m = new ChangePriority(CurrTicket);
                m.Show();
            }
            else
            {
                MessageBox.Show("Please select a Ticket before attempting to change the priority");
            }
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            //if a ticket is selected, open the changePriority menu
            if (ticketIDLabel.Text != "..")
            {
                Form m = new ChangeStatus(CurrTicket);
                m.Show();
            }
            else
            {
                MessageBox.Show("Please select a Ticket before attempting to change the status");
            }

        }
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
