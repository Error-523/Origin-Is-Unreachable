using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Rigidbody))]
public class CustomGravity_Net : NetworkBehaviour
{
    // Gravity Scale editable on the inspector
    // providing a gravity scale per object

    public float gravityScale = 1.0f;

    // Global Gravity doesn't appear in the inspector. Modify it here in the code
    // (or via scripting) to define a different default gravity for all objects.

    public static float globalGravity = -9.81f;

    Rigidbody m_rb;

    void OnEnable()
    {
        if (!isLocalPlayer)
            return;
        m_rb = GetComponent<Rigidbody>();
        if (m_rb == null)
            Debug.Log("PUTEUH !");
        m_rb.useGravity = false;
    }

    void FixedUpdate()
    {
        if (!isLocalPlayer)
            return;
        m_rb = GetComponent<Rigidbody>();
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        m_rb.AddForce(gravity, ForceMode.Acceleration);
        if (m_rb == null)
            Debug.Log("PUTEUH !");
    }
}