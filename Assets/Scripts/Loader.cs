using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

	public GameObject gameManager;

	#if UNITY_IOS ||  UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
	private float sW;
	private float sH;
	#endif

	// Use this for initialization
	void Awake () {
		if (GameManager.instance == null)
			Instantiate (gameManager);
	}

	#if UNITY_IOS ||  UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
	void Update()
	{
		sW = Screen.width;
		sH = Screen.height;

		if (Screen.width < Screen.height) {
			Camera.main.orthographicSize = (5f / (sW / sH));
		} else if (Screen.width > Screen.height) {
			Camera.main.orthographicSize = 5;
		}
	}
	#endif

}
