using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float rotate = 45f;
    public float jumpForce = 300;
    public float fallGravity = -10;
    public float fallTolerance= -1f;
    public int targetFrameRate = 60;
    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidBody.velocity;
        if (velocity.y < fallTolerance)
        {
            rigidBody.AddForce(0, fallGravity, 0);
        }

        velocity.z = speed;
        rigidBody.velocity = velocity;
    }
    private void Start()
    {
        Application.targetFrameRate = targetFrameRate;
    }
    void Update()
    {
        if(Input.GetButton("Jump") && IsTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            Vector3 velocity = rigidBody.velocity;
            velocity.y = jumpForce;
            rigidBody.velocity = velocity;
            
        }
        Rigidbody rigidBody2 = gameObject.GetComponent<Rigidbody>();
        rigidBody2.angularVelocity = new Vector3(rotate, 0, 0);

    }
    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        var transform1 = transform;
        return Physics.CheckBox(transform1.position, transform1.lossyScale / 0f, 
            transform1.rotation, layerMask);
    }
}