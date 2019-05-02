using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Using a design pattern and technology of your own choosing, develop 
 a console application that enables a user to perform the following operations: 

 1.	Create, edit and view information related to a ‘Customer’ including their: 
 •	First Name; 
 •	Surname; 
 •	Telephone; and, 
 •	Date of birth. 

 2.	Display a table of all customers with the following fields:  
 •	Display Name (i.e. “First name + Surname”); 
 •	Telephone; 
 •	Date of birth; 
 •	Age; and, 
 •	The background colour for each row should be set depending o the customer’s display name.
    The colour should be unique for customers with different display names (even if there are hundreds of customers)
    and the same for customers with exactly the same name. 
 */

namespace CustomerRegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRegister cr = new CustomerRegister();
        }
    }
}
