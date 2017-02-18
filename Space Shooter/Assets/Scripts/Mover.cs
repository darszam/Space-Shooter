using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        speed = 20;
    }
	// Use this for initialization
	void Start () {
        rb.velocity = transform.forward * speed;
       
	}
    void Update()
    {

    }
	
	
}
