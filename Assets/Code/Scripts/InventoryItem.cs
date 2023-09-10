using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InventoryClass
{
    sweep,
    cleaning,
    box
}

public class InventoryItem : MonoBehaviour
{
    public InventoryClass inventoryClass;
}
