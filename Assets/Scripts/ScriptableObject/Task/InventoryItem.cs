using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="UnnamedInvetoryObject", menuName = "Scriptable Object/InvetoryItem", order = 1)]
public class InventoryItem : ScriptableObject
{
    public int position;
    [SerializeField]
    private int amount;
}
