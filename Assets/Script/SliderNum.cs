using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderNum : MonoBehaviour {

	public Text text;

	// Update is called once per frame
	void Update () {
		Slider slider = this.GetComponent <Slider> ();
		text.text = slider.value.ToString();
	}
}
