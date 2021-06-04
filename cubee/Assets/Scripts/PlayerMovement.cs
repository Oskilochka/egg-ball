using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    //Fixed cause of using phisics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce* Time.deltaTime);  //Add a forward force

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}