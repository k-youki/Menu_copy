using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundVolumeChange : MonoBehaviour {

	public Slider bgmSlider;
	public Slider seSlider;



	void Update () {
		foreach (Transform child in transform) {
			child.GetComponent<AudioSource>().volume = seSlider.value / 10;
		}
		transform.FindChild ("BGM").gameObject.GetComponent<AudioSource>().volume = bgmSlider.value / 10;;
	}
}
