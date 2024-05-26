using UnityEngine;
using System.Collections;

public class speed_control : MonoBehaviour {

	public player_move cube;
	public float difference, last_score;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cube.point_counter >= last_score + difference) {
			cube.p_speed += .2f;
			last_score = cube.point_counter;
		}
		if(Input.GetKeyDown(KeyCode.Space))
			cube.p_speed += .2f;

	}
}
