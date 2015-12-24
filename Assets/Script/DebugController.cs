using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class DebugController : MonoBehaviour {

	public Text FPSText;

	void Awake(){
		#if UNITY_ANDROID
		FPSText.gameObject.SetActive(true);
		#endif
	}

	void Start(){
		#if UNITY_ANDROID
		InvokeRepeating (((Action)showFPS).Method.Name, 0.1f, 0.005f);
		#endif
	}

	private void showFPS(){
		FPSText.text = "FPS : " + ((int)(1.0f / Time.smoothDeltaTime)).ToString();
	}

}
