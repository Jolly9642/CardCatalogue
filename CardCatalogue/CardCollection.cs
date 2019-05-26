using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace CardCatalogue
{
    class CardCollection
    {
        private string CollectionName;
        private string CardName;
        private Double CardPrice;
        private bool InDeck;

        XmlSerializer serializer = new XmlSerializer(new CardCollection);

        public void CreateCollection(string collectionName)
        {
            //create a collection, and an XML file for it.
            CardCollection newCollection = new CardCollection();
            newCollection.CollectionName = collectionName;
            XmlDocument coll = new XmlDocument();
            
            File.Create(collectionName);
            
        }

    }
}
