using UnityEngine;

[RequireComponent(typeof(Collider))]
public class JumpPad : MonoBehaviour
{
    [Header("Salt")]
    public float jumpForce = 12f;
    public string playerTag = "Player";
    public float cooldown = 0.2f;

    [Header("Opcional")]
    public AudioClip jumpSound;

    float lastTime;

    void OnCollisionEnter(Collision collision)
    {
        TryLaunch(collision.collider);
    }

    void OnTriggerEnter(Collider other)
    {
        TryLaunch(other);
    }

    void TryLaunch(Collider other)
    {
        if (!other.CompareTag(playerTag)) return;
        if (Time.time - lastTime < cooldown) return;

        Rigidbody rb = other.attachedRigidbody;
        if (rb == null) return;

        lastTime = Time.time;

        Vector3 v = rb.linearVelocity; 
        v.y = jumpForce;
        rb.linearVelocity = v;

        if (jumpSound != null)
            AudioSource.PlayClipAtPoint(jumpSound, transform.position);
    }
}