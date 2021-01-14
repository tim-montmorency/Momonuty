using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldat : MonoBehaviour
{
     TextMesh textMesh;
     int life = 3;
    Collider2D collider;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = IntToRoman(life);
        collider = GetComponent<Collider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    string IntToRoman(int number)
    {
        if (number == 3) return "III";
        if(number == 2) return "II";
        if(number == 1) return "I";
        return "";
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life = life - 1;
        textMesh.text = IntToRoman(life);
        if (life == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            collider.enabled = false;
            rigidbody.simulated = false;
        }
    }
}
