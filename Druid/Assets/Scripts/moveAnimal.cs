using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAnimal : MonoBehaviour
{
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector3 movement;
    private float timeLeft;
    private Rigidbody rb;


    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate()
    {
        
        rb.AddForce(movement * maxSpeed);
    }

    
}
