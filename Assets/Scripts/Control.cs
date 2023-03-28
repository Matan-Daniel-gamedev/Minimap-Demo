using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Vector3 Vec;
    float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Vertical") * Time.deltaTime * speed;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.localPosition = Vec;
    }
}
