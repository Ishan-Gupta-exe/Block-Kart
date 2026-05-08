using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;
    private PlayerMovement movement;
    private Rigidbody rb;

    public float UpwardForce = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movement = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;

            FindFirstObjectByType<GameManager>().EndGame();        
            }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "JumpPad")
        {
            rb.AddForce(0, UpwardForce, 0, ForceMode.VelocityChange);
        }
    }
}
