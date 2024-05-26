using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class touch_control : MonoBehaviour {


	public void opengame()
	{
		SceneManager.LoadScene (1);
	}

	public void gohome()
	{
		SceneManager.LoadScene (0);
	}

}
