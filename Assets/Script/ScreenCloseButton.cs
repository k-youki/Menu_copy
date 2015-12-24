using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenCloseButton : MonoBehaviour {

	public GameObject screen;
	public GameObject blackPanel;

	public void OnClick() {
		blackPanel.SetActive(false);
		screen.GetComponent<Animator>().SetTrigger("Out");
	}

}
