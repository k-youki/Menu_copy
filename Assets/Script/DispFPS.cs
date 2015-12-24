using UnityEngine;
using System.Collections;

public class DispFPS : MonoBehaviour {

	void Update () {
		float fps = 1f / Time.deltaTime;
		Debug.LogFormat("{0}fps",fps);
	}
}
