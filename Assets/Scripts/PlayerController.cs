using System;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float speedForce = 0.04f;
    public int jumpPower = 300;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpPower, 0);
            
            
        }
        transform.Translate(0, 0, speedForce);
        
    }
}
