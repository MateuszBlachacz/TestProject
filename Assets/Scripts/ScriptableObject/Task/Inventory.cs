using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] InventoryItem[] itemList;
    // Start is called before the first frame update
    void Start()
    {
        checkItemList();
    }

    public void checkItemList()
    {
        foreach(InventoryItem Item in itemList)
        {
            Debug.Log($"Name: {Item.name} and position {Item.position}");
        }
    }
}
