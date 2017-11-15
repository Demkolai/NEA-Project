using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;

public class ItemDatabaseScript : MonoBehaviour {

    public TextAsset inventory;
    public static List<BaseItems> itemInventory = new List<BaseItems>();

    private List<Dictionary<string, string>> inventoryDictionary = new List<Dictionary<string, string>>();
    private Dictionary<string, string> invDictionary;


    private void Awake()
    {
        ReadItemsFromDatabase();
        for(int i = 0; i < inventoryDictionary.Count; i++)
        {
            //itemInventory.Add(new BaseItems(inventoryDictionary[i]));
        }
    }



    public void ReadItemsFromDatabase()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(inventory.text);
        XmlNodeList itemList = xmlDocument.GetElementsByTagName("Item");

        foreach(XmlNode itemInfo in itemList)
        {
            XmlNodeList itemContent = itemInfo.ChildNodes;
            invDictionary = new Dictionary<string, string>();

            foreach(XmlNode content in itemContent)
            {
                switch (content.Name)
                {
                    case "ItemName":
                        invDictionary.Add("ItemName", content.InnerText);
                        break;
                    case "ItemID":
                        invDictionary.Add("ItemID", content.InnerText);
                        break;
                    case "ItemType":
                        invDictionary.Add("ItemType", content.InnerText);
                        break;
                }
            }

            inventoryDictionary.Add(invDictionary);
        }

        

    }

}
