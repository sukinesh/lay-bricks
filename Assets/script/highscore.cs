using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscore : MonoBehaviour {

	public Text highsre,currentsre;

	// Use this for initialization
	void Start () {
		currentsre.text = "Current Score:" + PlayerPrefs.GetInt ("current score").ToString ();
		highsre.text = "high score:" + PlayerPrefs.GetInt("high Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
