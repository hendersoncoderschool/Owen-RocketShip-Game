using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public List<Transform> Waypoints;
    private int target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {target = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[target].position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, Waypoints[target].position) < 0.5) {
            target++;
            if (target >= Waypoints.Count)
            {
                target = 0;
            }
        }
    }
}
