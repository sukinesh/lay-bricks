using UnityEngine;
using System.Collections;

public class cam_move : MonoBehaviour {
	public Transform follow;
	public float camspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = new Vector3(follow.position.x,follow.position.y,gameObject.transform.position.z);
		gameObject.transform.position = Vector3.MoveTowards (transform.position, temp, camspeed);

		/*if (follow.position.y > (gameObject.transform.position.y + 3)) {
			gameObject.transform.position = new Vector3 (follow.position.x, follow.position.y, gameObject.transform.position.z);
		}

		if (follow.position.y < (gameObject.transform.position.y - 3)) {
			gameObject.transform.position = new Vector3 (follow.position.x, follow.position.y, gameObject.transform.position.z);
		}*/
		
	}
}
