using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{

    public float xPos;
    public float yPos;
    public float zPos;
    public float waiting = 0.02f;
    //Collider myCollider;

    void Awake()
    {
        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.y;
        zPos = gameObject.transform.position.z;
        //myCollider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    IEnumerator OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(xPos, yPos + 0.1f, zPos);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos + 0.2f, zPos);
            yield return new WaitForSeconds(waiting);
            this.transform.GetComponent<Collider>().isTrigger = false;
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos + 0.3f, zPos + 0.5f);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos + 0.4f, zPos + 1.0f);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 0.1f, zPos + 1.5f);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 0.6f, zPos + 2.0f);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 1.6f, zPos + 0.5f);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 2.6f, zPos + 0.5f);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(xPos, yPos - 4.0f, zPos + 0.5f);
            yield return new WaitForSeconds(0.25f);
            this.transform.GetComponent<Collider>().isTrigger = true;
            Destroy(gameObject);
        }
    }
}
