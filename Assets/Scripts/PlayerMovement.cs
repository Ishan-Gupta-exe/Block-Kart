using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // assigned rigidbody to rb
    public Rigidbody rb;    
    
    // Float is basically a box where we can store data as i have stored forwardforce in it
    // We Use it so that it can store decimal values otherwise we would have used int and other stuff
    
    public float ForwardForce = 1000f;
    public float SidewaysForce = 10f;
    
    void FixedUpdate()
    {   
      //Only For The Forward Movement Of The Player

      rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        // Movemnt Of the Player[Block]

        if (Input.GetKey(KeyCode.D)){

           rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A)){

           rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
         if(rb.position.y < -1f)
      {
         FindFirstObjectByType<GameManager>().EndGame();

      }
    }
}