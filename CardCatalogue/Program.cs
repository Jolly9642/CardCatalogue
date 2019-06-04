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
        /// This is a card cataloguer that creates XML files that are easily uploaded into excel or access. 
        /// It would also be a nice feature to connect to sites such as tcgplayer and update the price of each card.
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialForm());
          

        }
    }
}
