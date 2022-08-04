using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }
    public List<Item> items = new List<Item>();

    [Tooltip("Inventory > VP > Content")] public Transform itemContent;
    public GameObject InventoryItem;


    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public void ListItems()
    {
        foreach (var item in items)
        {
            GameObject obj = Instantiate(InventoryItem, itemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text   = item.itemName;
            itemIcon.sprite = item.itemIcon;

        }
    }
}
