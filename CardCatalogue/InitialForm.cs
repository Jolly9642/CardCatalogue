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
using System.Text.RegularExpressions;

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
            //this has data validation now.
            if(!Regex.IsMatch(nameOfCollection.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("You cannot create an empty named collection. Please name the collection.");
            }
            else
            {
                CardCollection newCollection = new CardCollection();
                newCollection.CreateCollection(nameOfCollection.Text);
                collectionListBox.Items.Clear();
                PopulateListBox(collectionListBox, @"collections", "*.xml");
            }

            

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
            //this has data validation now.
            if (collectionListBox.SelectedItem == null)
            {
                MessageBox.Show("please select a collection");
            }
            else
            {
                string selectedCollection = collectionListBox.SelectedItem.ToString();
                AddCardForm newCardForm = new AddCardForm(selectedCollection);
                newCardForm.Show();
                this.Hide();
            }

        }

        private void cardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void collectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Added data validation to the PopulateCardList method to stop any crashing from empty collections. 
            //Need to work on the formatting of the cardListBox.
            CardCollection lsbCollection = new CardCollection();
            List<CardCollection> listCollection = new List<CardCollection>();
            lsbCollection.PopulateCardList(listCollection, collectionListBox.SelectedItem.ToString());
            foreach(var item in listCollection)
            {
                cardListBox.Items.Add(item.CardName);
            }

        }

        private void removeCardButton_Click(object sender, EventArgs e)
        {
            CardCollection delCollection = new CardCollection();
            
            delCollection.RemoveCard(collectionListBox.SelectedItem.ToString(), cardListBox.SelectedItem.ToString());
            MessageBox.Show(cardListBox.SelectedItem.ToString());
        }
    }
}
