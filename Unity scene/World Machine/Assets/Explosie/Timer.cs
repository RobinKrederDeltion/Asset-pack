using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public float timer = 3.0f;

	// Use this for initialization
	void Start ()
    {
        transform.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= 1 * Time.deltaTime;
        
        if(timer < 0)
        {
            transform.GetComponent<Renderer>().enabled = true;
        }
	}
}
