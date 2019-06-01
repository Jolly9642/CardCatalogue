using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CardCatalogue
{
    public partial class AddCardForm : Form
    {
        public string currentColl;

        public AddCardForm(string collectionName)
        {
            InitializeComponent();
            currentColl = collectionName;
            collectionLabel.Text = "You are adding to: " + collectionName;
           
        }

        private void submitCardButton_Click(object sender, EventArgs e)
        {
            //this now has data validation
            CardCollection coll = new CardCollection();
            double price;
            bool isDouble = Double.TryParse(priceInput.Text, out price);
            if (!Regex.IsMatch(cardNameInput.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("You must enter a name for the card.");
            }
            else if(isDouble == false)
            {
                MessageBox.Show("You must enter a valid number for the price of the card.");
            }
            else
            {
                //This makes a call to the AddCard method in the CardCollection class to add a new card based on the data in the form.
                coll.AddCard(currentColl, cardNameInput.Text, Convert.ToDouble(priceInput.Text), Convert.ToBoolean(inDeckRadio.Checked));
            }

           

        }

        private void backToCollectionsButton_Click(object sender, EventArgs e)
        {
            InitialForm initForm = new InitialForm();
            initForm.Show();
            this.Close();
        }
    }
}
