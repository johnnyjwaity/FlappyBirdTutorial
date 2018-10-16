using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    //Store the Rigidbody2D
    private Rigidbody2D rb;
    //Variable for affecting the strength of the bird
    public float strength;

    

	// Use this for initialization
	void Start () {
        //Get The Rigidbody2D from the bird
        rb = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // This will change the velocity of the bird to go upwards whenever Space is pressed
            rb.velocity = Vector2.up * strength;
        }
	}
}
