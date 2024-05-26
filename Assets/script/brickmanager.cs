using UnityEngine;
using System.Collections;

public class brickmanager : MonoBehaviour {

	public GameObject plane,stepup,stepdown;
	public Transform start_point;

	// Use this for initialization
	void Start () {
		install (plane, 0);install (plane, 0);

	}

	public void touch_buttons(int button_no)
	{
		if (button_no == 0)
			install (plane, 0);
		else if (button_no == 1)
			install (stepup, 1f);
		else
			install (stepdown, -1f);
	}

	public void install(GameObject brick, float y)
	{
		Vector3 temp = new Vector3 (-4f, y, 0);
		Instantiate (brick,start_point.position,start_point.rotation);

		start_point.transform.position += temp ;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow))
			install (plane, 0);
		if (Input.GetKeyDown (KeyCode.RightArrow))
			install (stepup, 1f);
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			install (stepdown, -1f);
	}
}
