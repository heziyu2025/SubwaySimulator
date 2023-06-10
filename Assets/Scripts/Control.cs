using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Logger('Hello World');
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 a = gameObject.transform.position;
            a.x += 0.1f;
            gameObject.transform.position = a;
        }
    }
}
