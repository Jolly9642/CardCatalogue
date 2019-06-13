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
