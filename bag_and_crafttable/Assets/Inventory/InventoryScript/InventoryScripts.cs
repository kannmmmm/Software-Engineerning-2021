﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/New Inventory")]
public class InventoryScripts : ScriptableObject
{
    public List<Item> itemList = new List<Item>();
}
