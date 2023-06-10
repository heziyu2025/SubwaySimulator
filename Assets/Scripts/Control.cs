using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float acc = 0.5f;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = gameObject.transform.localPosition;
        a.x += speed;
        gameObject.transform.localPosition = a;

        if (Input.GetKey(KeyCode.W))
        {
            speed += acc / 1000;
        } else
        {
            speed *= 0.99f;
        }
    }
}
