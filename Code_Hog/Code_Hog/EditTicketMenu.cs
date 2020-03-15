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
    public partial class EditTicketMenu : Form {
        public EditTicketMenu() {
            InitializeComponent();
        }


        private void DeleteTicketButton_Click(object sender, EventArgs e)
        {
            //This is to prevent the user from creating multiple deleteTicketMenu forms
            DeleteTicketMenu deleteTicketMenu = new DeleteTicketMenu();
            foreach (Form form in Application.OpenForms)
            {
                if (form is DeleteTicketMenu)
                {
                    form.Focus();
                    return;
                }
            }
            deleteTicketMenu.Show();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //TO DO: Save ticket changes before closing
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
