using UnityEngine;
using System.Collections;

public class diam_creator : MonoBehaviour {

	public Transform diam_point;
	public GameObject diamond;

	void Start () {
		instantiation (0);
		diam_create ();
		diam_create ();

	}

	public void diam_create()
	{
		instantiation (Random.Range (-1, 2));
	}

	void instantiation(int ypos)
	{
		diam_point.transform.position += new Vector3 (-4f, ypos , 0);
		Instantiate (diamond, diam_point.position, diam_point.rotation);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
