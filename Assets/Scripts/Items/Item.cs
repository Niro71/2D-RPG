using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public abstract class Item : ScriptableObject 
{
  [Header("Item Variables")]
  // Name of the item, as appears in the inventory
  // Cannot use 'name', as it hides inherited member 'Object.name'
  public string itemName;

  // Icon's image, displays in the inventory
  public Sprite icon;

  // Tier of the item, similar to a rarity
  // (1, 2, 3) = (T1, T2, T3) 
  [Range(1, 9)]
  public int tier;

  // Use function handles specific item's use cases, including
  // consumables, equippables, etc.
  public virtual void Use() {
    Debug.Log("Item used: " + itemName);
  }
}
