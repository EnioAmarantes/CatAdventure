using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        vel = 10;
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
