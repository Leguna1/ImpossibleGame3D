using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedForce = 0.04f;
    public float groundRotationSpeed = 10f;
    public float airRotationSpeed = 5f;
    public float jumpForce = 300f;

    private bool isGrounded;
    private float rotationSpeedMultiplier = 1.0f;

    void Update()
    {
        // Check if the player is grounded
        isGrounded = IsTouchingGround();

        // Movement
        transform.Translate(0, 0, speedForce, Space.World);

        // Rotation
        float rotationSpeed = isGrounded ? groundRotationSpeed : airRotationSpeed;
        float rotationAmount = speedForce * rotationSpeedMultiplier * rotationSpeed * Time.fixedDeltaTime;
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(rotationAmount, 0, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.1f);

        // Jumping
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpForce, 0);
            rotationSpeedMultiplier = 1.5f; // Slow down rotation in the air
        }
        else if (isGrounded)
        {
            rotationSpeedMultiplier = 3.0f; // Restore normal rotation speed on the ground
        }
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.NameToLayer("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}