using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCatalogue
{
    public partial class AddCardForm : Form
    {
       
        public AddCardForm(string collectionName)
        {
            InitializeComponent();
            collectionLabel.Text = collectionName;
           
        }

        private void submitCardButton_Click(object sender, EventArgs e)
        {
            CardCollection coll = new CardCollection();

            //This makes a call to the AddCard method in the CardCollection class to add a new card based on the data in the form.
            coll.AddCard(collectionLabel.Text, cardNameInput.Text, Convert.ToDouble(priceInput.Text), Convert.ToBoolean(inDeckRadio.Checked));

        }
    }
}
