using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Enter : MonoBehaviour {

    public GameObject PipeEntry;
    public int stoodOn;
    //CharacterController controller;
    public Animator anim;

	// Use this for initialization
	void Start ()
    {
        //controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
    {
        stoodOn = 1;
	}

    void OnTriggerExit(Collider col)
    {
        stoodOn = 0; 
    }

    void Update()
    {
        if (Input.GetButtonDown("GoDown"))
        {
            if(stoodOn == 1)
            {
                //controller.enabled = false;
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(WaitingForPipe());
                print("Start pipe descent");
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        //print("Start animation");
        anim.enabled = true;
        //anim.weight = 1.0f;
        
        yield return new WaitForSeconds(1.99f);
        anim.enabled = false;
        //controller.enabled = true;
        
    }
}
