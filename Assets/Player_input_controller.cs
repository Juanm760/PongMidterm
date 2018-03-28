using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_input_controller : MonoBehaviour {
    //Input for the two players
    public GameObject leftbat;
    public GameObject rightbat;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        leftbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey (KeyCode.W))
        {
            leftbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            leftbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);
        }


        rightbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rightbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);
        }



    }
}
