using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CustomGravity : MonoBehaviour
{
    public float jumpForce;
    public float FloorPos;
    // Gravity Scale editable on the inspector
    // providing a gravity scale per object

    public float gravityScale = 1.0f;

    // Global Gravity doesn't appear in the inspector. Modify it here in the code
    // (or via scripting) to define a different default gravity for all objects.

    public static float globalGravity = -9.81f;

    Rigidbody m_rb;

    private void Start()
    {
        //controller = GetComponent<CharacterController>();
        m_rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        m_rb = GetComponent<Rigidbody>();
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        if (m_rb.position.y < FloorPos)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_rb.velocity = Vector3.up * jumpForce;
                return;
            }
            
        }
        m_rb.AddForce(gravity, ForceMode.Acceleration);

    }
}