using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//attach onto sprite (player image) in order for code to be used and allow adjustment for speed to be used
public class PlayerMovement : MonoBehaviour {
     public float speed = 0f; 
    
    void Update() //calls for update every frame
    {
        Vector3 pos = transform.position;   //vector3 makes use of x, y, and z pos
        //input get key allows for keyboard inputs to be used
        if (Input.GetKey("w")) {
            pos.y += speed * Time.deltaTime; //speed x delta time allows for smooth movment
        }

        if (Input.GetKey("s")) {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d")) {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("a")) {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
        //y += up y-= down x += right x -= left (they just invert based on + or -)
        //dash
        
    }
}
   
