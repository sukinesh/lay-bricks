using UnityEngine;
using System.Collections;

public class distroy_brick : MonoBehaviour {


	public GameObject cam_pos;

	void Start() {
		cam_pos = GameObject.Find ("player");

	}

	void Update()
	{
		if (cam_pos.transform.position.x < (this.transform.position.x - 40)) 
			GameObject.Destroy (gameObject);	

	}


}
