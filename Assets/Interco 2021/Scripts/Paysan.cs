using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paysan : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 impulse = new Vector2(1, 1);
    public float torque = -0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            rb.AddTorque(torque, ForceMode2D.Impulse);
            rb.AddForce(impulse, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            rb.AddTorque(torque, ForceMode2D.Impulse);
            rb.AddForce(impulse * -1, ForceMode2D.Impulse);
        }
    }
}
