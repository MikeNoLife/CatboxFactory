using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLoweringMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lowerHitbox = GameObject.Find("LowerHitbox").transform.position;
        float step = 1 * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, lowerHitbox, step);
        if (transform.position == lowerHitbox)
        {
            Destroy(GetComponent<BoxLoweringMovement>());
        }
    }
}
