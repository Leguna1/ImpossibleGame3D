using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedForce = 1f; 
    public int jumpForce = 300;
   void Update()
    {
        transform.Translate(0, 0, speedForce);
       if (Input.GetButtonDown("Jump") && IsTouchingGround())
        { 
          Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpForce, 0);
        }
    }

   private bool IsTouchingGround()
   {
       int layerMask = LayerMask.GetMask("Ground");
       return Physics.CheckBox(transform.position,transform.lossyScale /1.99f,
           transform.rotation, layerMask);
   }
}
