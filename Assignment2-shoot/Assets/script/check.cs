using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    void OnJointBreak(float breakForce)
    {
        Debug.Log("You Win!! ");
    }
}
