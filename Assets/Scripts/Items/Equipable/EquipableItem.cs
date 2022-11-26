using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equippable", menuName = "Items/Equippable/New Equippable")]
public class EquipableItem : Item 
{
  public SlotType inventorySlot;
  public List<EquippableStat> equippableStats = new List<EquippableStat>();

  public override void Use() {
    Debug.Log("Equipped: " + itemName);
  }
}
