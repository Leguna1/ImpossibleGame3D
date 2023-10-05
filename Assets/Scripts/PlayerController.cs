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
            if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpPower, 0);
            rigidbody.angularVelocity = new Vector3(2, 0, 0);
        }
        transform.Translate(0, 0, speedForce, Space.World);

        bool IsTouchingGround()
        {
            int layerMask = LayerMask.NameToLayer("Ground");
            return Physics.CheckBox(transform.position, transform.lossyScale / 
                                                        1.99f, transform.rotation, layerMask);
        }
    }
    
}
