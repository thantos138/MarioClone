using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public Transform Player;
	public float distanceFromPlayer;
	public float staticCameraY;

	void Update()
	{
		gameObject.transform.position = new Vector3(Player.position.x, staticCameraY, Player.position.z - distanceFromPlayer);
	}

	void LateUpdate()
	{
		//GetComponent<Camera.main>().transform.position = staticCameraY;
	} 
}