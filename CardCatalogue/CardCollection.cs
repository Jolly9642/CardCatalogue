using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Data.Linq;
using System.Web;
using System.Diagnostics;
using HtmlAgilityPack;


namespace CardCatalogue
{
  public class CardCollection
    {
        public string CollectionName { get; set; }
        public string CardName { get; set; }
        public double CardPrice { get; set; }
        public bool InDeck { get; set; }
       
        
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

        public void AddCard(string iCollectionName, string iCardName, double iCardPrice, bool iInDeck)
        {
            //This adds card to a collection. 
            CardCollection newCard = new CardCollection();
            List<CardCollection> collList = new List<CardCollection>();
            //the PopulateCardList method fills the list with all the card before the one being added.
            newCard.PopulateCardList(collList, iCollectionName);
            newCard.CollectionName = iCollectionName;
            newCard.CardName = iCardName;
            newCard.CardPrice = iCardPrice;
            newCard.InDeck = iInDeck;
            
            collList.Add(newCard);

            XmlSerializer xs = new XmlSerializer(typeof(List<CardCollection>));
            File.Delete(iCollectionName);
            using (FileStream fs = new FileStream(@"collections\" + iCollectionName, FileMode.Create))
            {
                xs.Serialize(fs, collList);
            }
            MessageBox.Show("card added here: " + @"collections\" + iCollectionName);
        }

        public void RemoveCard(string rCollectionName, string cardToDelete)
        {
            
            CardCollection delColl = new CardCollection();
            List<CardCollection> rlstOfCards = new List<CardCollection>();
            delColl.PopulateCardList(rlstOfCards, rCollectionName);
            for(int i = 0; i < rlstOfCards.Count; i++)
            {
                if (rlstOfCards[i].CardName == cardToDelete)
                {
                    rlstOfCards.RemoveAt(i);   
                }
            }

            delColl.SaveCollection(rCollectionName, rlstOfCards);

        }

        public void EditCard(string eCollectionName, string eCardName)
        {
            //This might be pointless. 
            CardCollection editColl = new CardCollection();
            List<CardCollection> eLstOfCard = new List<CardCollection>();
            editColl.PopulateCardList(eLstOfCard, eCollectionName);
            for(int i = 0; i<eLstOfCard.Count; i++)
            {
                if(eLstOfCard[i].CardName == eCardName)
                {
                    eLstOfCard.RemoveAt(i);
                    
                }
            }


        }

        public void SaveCollection(string sCollectionName, List<CardCollection> lstOfCards)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<CardCollection>));
            File.Delete(sCollectionName);
            using (FileStream fs = new FileStream(@"collections\" + sCollectionName, FileMode.Create))
            {
                xs.Serialize(fs, lstOfCards);
            }
        }

        public List<CardCollection> PopulateCardList(List<CardCollection> pCardList, string pCollectionName)
        {
            //this populates a list with the previous cards that were added to the card collection.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"collections\" + pCollectionName);
            XmlNodeList xCollectionName = xmlDoc.GetElementsByTagName("CollectionName");
            XmlNodeList xCardName = xmlDoc.GetElementsByTagName("CardName");
            XmlNodeList xCardPrice = xmlDoc.GetElementsByTagName("CardPrice");
            XmlNodeList xInDeck = xmlDoc.GetElementsByTagName("InDeck");

            for (int i = 0; i < xCollectionName.Count; i++)
            {
                CardCollection arColl = new CardCollection();
                if(xCardName[i]== null)
                {
                    return pCardList;
                }
                else if(xCardPrice[i] == null)
                {
                    return pCardList;
                }
                arColl.CollectionName = xCollectionName[i].InnerText;
                arColl.CardName = xCardName[i].InnerText;
                arColl.CardPrice = XmlConvert.ToDouble(xCardPrice[i].InnerText);
                arColl.InDeck = XmlConvert.ToBoolean(xInDeck[i].InnerText);
                pCardList.Add(arColl);
            }
            return pCardList;
        }

       



    }
}
