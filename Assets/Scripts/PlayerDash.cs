using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour {

    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (direction == 0) {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space)) { //dash up
                direction = 1;
            } else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space)) { //dash down
                direction = 2;
            } else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.Space)) { //dash left
                direction = 3;
            } else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Space)) { //dash right
                direction = 4;
            }
        } else {
            if (dashTime <= 0) {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            } else {
                dashTime -= Time.deltaTime;

                if (direction == 1) {
                    rb.velocity = Vector2.up * dashSpeed;
                } else if (direction == 2) {
                    rb.velocity = Vector2.down * dashSpeed;
                } else if (direction == 3) {
                    rb.velocity = Vector2.left * dashSpeed;
                } else if (direction == 4) {
                    rb.velocity = Vector2.right * dashSpeed;
                }
            }
        }
    }
}