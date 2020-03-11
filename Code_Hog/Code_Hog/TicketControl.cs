using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Hog
{
    class TicketControl
    {
        //used for holding ticket data in functions
        struct data
        {
            public int ticketNumber; //derived from DB on creation
            public int priority; // 1-5. 1 = High Priority, 5 = Low Priority
            public string name; //name of ticket, should only be X characters long
            public string initialRep; //Name of initial reporter
            public int status; //1 = Unresolved, 2 = Being Addressed/Fixed, 3 = Archived/Fixed/Ignored
            public string contributors; //List of all users who have contributed to the ticket
            public string description; //Description of issue
            public string dependancies; //Notes regarding related issues
            public string[] notes; //Notes regarding the issue and efforts to fix it
            
        }

        //Create new ticket in DB
        public void CreateTicket(int inPriority, string inName, string repName, string inDesc)
        {
            data newTicket;

            //get next available ticket #
            //TODO

            //assign ticket number to next available ticket #
            //TODO

            //assign priority
            newTicket.priority = inPriority;

            //assign name
            newTicket.name = inName;

            //assign initial reporter name
            newTicket.initialRep = repName;

            //assign description of issue
            newTicket.description = inDesc;

            //push ticket to DB
            //TODO

        }

        //Edit existing Ticket in DB

        //get specified ticket information from DB
    }
}
