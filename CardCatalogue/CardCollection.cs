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
        private string CollectionName { get; set; }
        private string CardName { get; set; }
        private double CardPrice { get; set; }
        private bool InDeck { get; set; }

       

        public void CreateCollection(string collectionName)
        {
            //create a collection, and an XML file for it.
            CardCollection newCollection = new CardCollection();
            newCollection.CollectionName = collectionName;
            XmlSerializer xs = new XmlSerializer(typeof(CardCollection));
            if (!Directory.Exists("collections"))
            {
                Directory.CreateDirectory("collections");
            }
            using (FileStream fs = new FileStream(@"collections\"+collectionName +".xml", FileMode.Create))
            {
                xs.Serialize(fs, newCollection);
            }
            MessageBox.Show("collection created");

        }

        public void AddCard(string collectionName, string iCardName, double iCardPrice, bool iInDeck)
        {
           


            //it'll save but it won't actually add the elements of the ccardcollection list. 
            List<CardCollection> collList = new List<CardCollection>();
            CardCollection coll = new CardCollection();
            coll.CollectionName = collectionName;
            coll.CardName = iCardName;
            coll.CardPrice = iCardPrice;
            coll.InDeck = iInDeck;

            
            collList.Add(coll);

            XmlSerializer xs = new XmlSerializer(typeof(List<CardCollection>));
            File.Delete(collectionName);
            using (FileStream fs = new FileStream(@"collections\" + collectionName, FileMode.Create))
            {
                xs.Serialize(fs, collList);
            }
            MessageBox.Show("card added");

        }




    }
}
