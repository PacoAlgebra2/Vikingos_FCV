using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar2 : MonoBehaviour
{
    public float vg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, vg, 0.0f, Space.Self);
    }
}
