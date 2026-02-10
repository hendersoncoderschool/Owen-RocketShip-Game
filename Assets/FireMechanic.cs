using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMechanic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().health -= 1;
        }
        Destroy(gameObject);
    }
}
