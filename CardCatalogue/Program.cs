using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCatalogue
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialForm());
            //Card collections are being created successfully. Need to make a form that will show card names, prices, and whether or not they are in a deck. 
            //Next steps will be possibly finding a way to connect to an online database of card prices so if you are online you can update all your card prices with a button press. 
            // 05/31/2019

        }
    }
}
