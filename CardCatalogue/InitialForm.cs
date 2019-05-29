using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CardCatalogue
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            PopulateListBox(collectionListBox, @"collections", "*.xml");
            
            
        }

        private void collectionNameButton_Click(object sender, EventArgs e)
        {
            CardCollection newCollection = new CardCollection();
            newCollection.CreateCollection(nameOfCollection.Text);

        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        private void collectionSelectionButton_Click(object sender, EventArgs e)
        {
            string selectedCollection = collectionListBox.SelectedItem.ToString();
            AddCardForm newCardForm = new AddCardForm(selectedCollection);
            newCardForm.Show();
        }
    }
}
