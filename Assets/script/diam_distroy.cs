using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class diam_distroy : MonoBehaviour {

	public diam_creator create_one;
	public player_move point;
	public Transform player_pos;
	bool repeat = true;


	void OnTriggerEnter ()
	{
		create_one.diam_create ();
		GameObject.Destroy (this.gameObject);
		point.point_counter += 1;
	}

	void Update()
	{
		
		if ((player_pos.position.x < this.transform.position.x) && repeat) {
			
				print ("GAME OVER :(");
			PlayerPrefs.SetInt ("current score", point.point_counter);
			if (PlayerPrefs.GetInt ("high Score") < point.point_counter) {
				PlayerPrefs.SetInt ("high Score", point.point_counter);
			}
			SceneManager.LoadScene (2);
			repeat = false;
		}
		
	}

}
