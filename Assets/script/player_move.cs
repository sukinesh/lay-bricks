using UnityEngine;
using System.Collections;

public class player_move : MonoBehaviour {

	public float p_speed, sphere_radius,jump_height, towardsspeed;
	public bool touch_ground, touch_wall;
	public LayerMask ground;
	public Transform front_sphere_center, bottom_sphere_center;
	public Collider[] col_wall, col_ground;
	public int point_counter,lost_diam;


	void Start () {
		point_counter = 0;
	}

	/*void FixedUpdate()
	{ print (Time.deltaTime);
		var pos = gameObject.transform.position;
		Vector3 tempv = new Vector3 (pos.x-1f,pos.y,pos.z);
		gameObject.transform.position = Vector3.MoveTowards (transform.position, tempv, towardsspeed);
	}*/

		
	void Update () {
		col_wall = Physics.OverlapSphere (front_sphere_center.position, sphere_radius, ground) ;
		col_ground = Physics.OverlapSphere (bottom_sphere_center.position, sphere_radius, ground);

		touch_wall = col_wall.Length != 0;
		touch_ground = col_ground.Length != 0;
		if (touch_ground && touch_wall) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (GetComponent<Rigidbody>().velocity.x, jump_height , 0f);

		}


		//if(Input.GetKey(KeyCode.Space))
		GetComponent<Rigidbody> ().velocity = new Vector3 (-p_speed, GetComponent<Rigidbody>().velocity.y, 0);
	}
}
