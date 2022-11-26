using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable", menuName = "Items/Consumables/New Consumable")]
public class ConsumableItem : Item 
{
  // Consumable type
  public enum ConsumableType {
    HEALTH,
    MANA
  }

  // When a consumable is used, we will use this to determine whether the consumable should
  // add to the variable as a flat or percentage
  public enum ConsumableAmountType {
    FLAT,
    PERCENTAGE
  }

  public ConsumableType _type;
  public ConsumableAmountType _amountType;

  // The amount the consumable improves, will be added based on the ConsumableAmountType 
  public int amount;
  
  public override void Use() {
    Debug.Log("Consumable used: " +  _type + " " + amount + " " + _amountType);
  }
}
