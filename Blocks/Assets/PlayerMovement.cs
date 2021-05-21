using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 300f;
    public float sideways_force = 300f;


    void FixedUpdate()
    {
        rb.AddForce(0, 0, forward_force * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideways_force * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideways_force * Time.deltaTime, 0, 0);
        }
    }
}
