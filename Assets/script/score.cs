using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {


	public Text cscore;
	public player_move playerr;

	// Use this for initialization
	void Start () {
		}

	// Update is called once per frame
	void Update () {
		cscore.text = playerr.point_counter.ToString();
	}
}
