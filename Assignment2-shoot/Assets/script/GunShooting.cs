using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
GameObject clone = Instantiate(bullet,transform.position,transform.rotation)as GameObject;
        }
    }
}
