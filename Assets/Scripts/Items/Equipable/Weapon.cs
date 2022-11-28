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
  [Range(1, 20)]
  public int bulletSpeed;

  private Transform firePoint; 

  public override void Use() {
    Debug.Log("Weapon equipped: " + itemName);
  }

  public int calculateBaseDamage() {
    return Random.Range(minBaseDamage, maxBaseDamage);
  }

  public void Fire(Player _player) {
    GameObject bulletClone = Instantiate(bullet, _player.firePoint.position, Quaternion.identity);
    Rigidbody2D bulletRb = bulletClone.GetComponent<Rigidbody2D>();

    Vector3 direction = _player.p_mousePos - bulletClone.transform.position;
    Vector3 rotation = bulletClone.transform.position - _player.p_mousePos;

    bulletRb.velocity = new Vector2(direction.x, direction.y).normalized * (bulletSpeed * 5);

    float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

    // Add +90 to rot if the bullet is horizontal
    bulletClone.transform.rotation = Quaternion.Euler(0, 0, rot);
  } 
}
