using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNotDestroy : MonoBehaviour {

    public float xPos;
    public float yPos;
    public float zPos;
    //Collider myCollider;

    void Awake()
    {
        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.y;
        zPos = gameObject.transform.position.z;
        //myCollider = gameObject.GetComponent<Collider>();
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        this.transform.GetComponent<Collider>().isTrigger = false;
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(xPos, yPos + 0.2f, zPos);
            yield return new WaitForSeconds(0.08f);
            this.transform.position = new Vector3(xPos, yPos, zPos);
            yield return new WaitForSeconds(0.25f);
            this.transform.GetComponent<Collider>().isTrigger = true;
        }
    }
}
