using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenManager : MonoBehaviour {

	public float delayTime;

	// Use this for initialization
	void Start () {
		StartCoroutine ("SplashScreen");
	}
	
	IEnumerator SplashScreen () {
		yield return new WaitForSeconds (delayTime);
		SceneManager.LoadScene ("MainMenu");
		Debug.Log("udah di scene");
	}
}
