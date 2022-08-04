using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;

    public Item item;

    private void Pickup()
    {
        InventoryManager.Instance.AddItem(item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
    }
}
