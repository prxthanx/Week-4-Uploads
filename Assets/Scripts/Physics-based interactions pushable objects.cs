using UnityEngine;

public class PushObjects : MonoBehaviour
{
    public float pushForce = 5f;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.attachedRigidbody;

        // Ensure the object has a Rigidbody and isn't kinematic
        if (rb != null && !rb.isKinematic)
        {
            Vector3 forceDirection = collision.contacts[0].normal;
            rb.AddForce(-forceDirection * pushForce, ForceMode.Impulse);
        }
    }
}
