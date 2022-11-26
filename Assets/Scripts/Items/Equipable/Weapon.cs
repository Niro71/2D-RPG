using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Equippable/New Weapon")]
public class Weapon : EquipableItem 
{
  // This takes into account for the weapon's base damage, does not factor into
  // the damage stat
  [Header("Damage")]
  public int minBaseDamage;
  public int maxBaseDamage;
  
  [Header("Bullet")]
  public GameObject bullet;
  public int bulletSpeed;

  public override void Use() {
    Debug.Log("Weapon equipped: " + itemName);
  }

  public int calculateBaseDamage() {
    return Random.Range(minBaseDamage, maxBaseDamage);
  }
}
