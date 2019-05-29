using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace CardCatalogue
{
  public class CardCollection
    {
        private string CollectionName;
        private string CardName;
        private double CardPrice;
        private bool InDeck;

       

        public void CreateCollection(string collectionName)
        {
            //create a collection, and an XML file for it.
            CardCollection newCollection = new CardCollection();
            newCollection.CollectionName = collectionName;
            XmlSerializer xs = new XmlSerializer(typeof(CardCollection));
            if (!System.IO.Directory.Exists("collections"))
            {
                System.IO.Directory.CreateDirectory("collections");
            }
            using (FileStream fc = new FileStream(@"collections\"+collectionName +".xml", FileMode.Create))
            {
                xs.Serialize(fc, newCollection);
            }
            MessageBox.Show("collection created");

        }

        public void AddCard(string collectionName, string iCardName, double iCardPrice, bool iInDeck)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(collectionName);
            CardCollection coll = new CardCollection();
            coll.CardName = iCardName;
            coll.CardPrice = iCardPrice;
            coll.InDeck = iInDeck;
            XmlSerializer xs = new XmlSerializer(typeof(CardCollection));
            // File.Delete(collectionName);
            using (FileStream fc = new FileStream(collectionName, FileMode.Append))
            {
                xs.Serialize(fc, coll);
            }
            MessageBox.Show("collection created");

        }




    }
}
