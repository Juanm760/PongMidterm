using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_script : MonoBehaviour {


    Rigidbody rb;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 3);

        Vector3 launchDirection = new Vector3();
        //Xdirection
        if(xDirection == 0)
        {
            launchDirection.x = -8f;
        }
        if(xDirection == 1)
        {
            launchDirection.x = 8f;
        }
        //ydirection
        if (yDirection == 0)
        {
            launchDirection.y = -8f;
        }
        if (yDirection == 1)
        {
            launchDirection.y = 8f;
        }
        if (yDirection == 2)
        {
            launchDirection.y = 0f;
        }



        rb.velocity = launchDirection;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "TopBounds")
        {
            float speedInXDirection = 0f;

            if(rb.velocity.x > 0f)
            {
                speedInXDirection = 8f;
            }
            if(rb.velocity.x < 0f)
            {
                speedInXDirection = -8f;
            }

            rb.velocity = new Vector3(speedInXDirection, -8f, 0f);
        }

        if (hit.gameObject.tag == "BottomBounds")
        {
            float speedInXDirection = 0f;

            if (rb.velocity.x > 0f)
            {
                speedInXDirection = 8f;
            }
            if (rb.velocity.x < 0f)
            {
                speedInXDirection = -8f;
            }

            rb.velocity = new Vector3(speedInXDirection, -8f, 0f);
        }

        if(hit.gameObject.name == "Left_Bat")
        {
            rb.velocity = new Vector3(13f, 0f, 0f);
            if(transform.position.y - hit.gameObject.transform.position.y < -.5)
            {
                rb.velocity = new Vector3(8f, -8f, 0f);
            }

            if (transform.position.y - hit.gameObject.transform.position.y > .5)
            {
                rb.velocity = new Vector3(8f, 8f, 0f);
            }

        }
        if (hit.gameObject.name == "Right_Bat")
        {
            rb.velocity = new Vector3(-13f, 0f, 0f);
            if (transform.position.y - hit.gameObject.transform.position.y < -.5)
            {
                rb.velocity = new Vector3(-8f, -8f, 0f);
            }

            if (transform.position.y - hit.gameObject.transform.position.y > .5)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }
        }



    }
}
