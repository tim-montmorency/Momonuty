using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour
{
    public float amount = 10f;
    public float speed = 1.5f;
    float phase;

    // Start is called before the first frame update
    void Start()
    {
        phase = Random.Range(0, Mathf.PI * 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = Mathf.Cos(phase) * amount;
        phase += speed * Time.deltaTime;
   
        Quaternion target = Quaternion.Euler(0, 0, zRotation);
        transform.rotation = target;
    }
}
