using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float forwardBack = Input.GetAxis(InputAxes.Vertical);
      float leftRight = Input.GetAxis(InputAxes.Horizontal);

        transform.Translate(0, 0, forwardBack * speed * Time.deltaTime, Space.Self);
        transform.Translate(leftRight * speed * Time.deltaTime, 0, 0, Space.Self);
    }
}
