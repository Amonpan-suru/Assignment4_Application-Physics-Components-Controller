using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{

[SerializeField] float speed;
    // Update is called once per frame
    void Update() {       
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0f,speed*Time.deltaTime,0f);
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0f, -speed*Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(0f, 0f, speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(0f,0f,-speed*Time.deltaTime);
        }
    }

}
