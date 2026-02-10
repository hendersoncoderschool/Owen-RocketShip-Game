using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss : MonoBehaviour { 
    Rigidbody rb;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = player.transform.position - transform.position;
        rb.AddForce(direction.normalized * 10f);
        
    }
}
