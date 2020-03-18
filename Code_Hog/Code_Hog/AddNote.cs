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

        public AddNote(int ticketNum)
        {
            InitializeComponent();

            //set the title component labels to the correct text
            ticketNumPrintLabel.Text = ticketNum.ToString();
            
            //TODO

        }

        //Adds note
        private void button1_Click(object sender, EventArgs e)
        {
            newNote = noteTextBox.Text;

            //update the ticket entry with the new note text and username
            //TODO

            //close the form
            this.Close();
        }
    }
}
