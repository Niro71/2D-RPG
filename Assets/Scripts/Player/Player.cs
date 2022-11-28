using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [Header("Player Stats")]
  public int playerHealth;
  public int maxPlayerHealth;

  public int playerDamage;
  public int playerSpeed;
  public int playerDefense;

  [Header("Player Equipment")]
  public Weapon weapon;
  public EquipableItem helmet;
  public EquipableItem chestplate;
  public EquipableItem leggings;
  public EquipableItem boots;

  [Header("Attached Objects")]
  public Rigidbody2D rb;
  public Camera cam;
  public Transform firePoint;

  [Header("Camera & Movement Info")]
  public Vector2 p_Movement;
  public Vector3 p_mousePos;

  private void Awake() {
    firePoint = this.transform.Find("FirePoint"); 
    rb = GetComponent<Rigidbody2D>();
  }

  private void Update() {
    // Updates p_Movement based on Input.GetAxisRaw()
    UpdateMovementAxis();

    // Updates mouse position based on ScreenToWorldPoint
    UpdateMousePosition();

    // If we're holding left click, fire our weapon
    if (Input.GetMouseButtonDown(0)) {
      weapon.Fire(this);
    }
  }

  private void FixedUpdate() {
    // Handle player movement
    onPlayerMove();
  }

  private void UpdateMovementAxis() {
    p_Movement.x = Input.GetAxisRaw("Horizontal");
    p_Movement.y = Input.GetAxisRaw("Vertical");
  }

  private void UpdateMousePosition() {
    p_mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    
    Vector3 rotation = p_mousePos - firePoint.position;

    float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

    firePoint.rotation = Quaternion.Euler(0, 0, rotZ);
  }

  private void onPlayerMove() {
    rb.MovePosition(rb.position + p_Movement * (playerSpeed * 10) * Time.fixedDeltaTime);
  }
}
