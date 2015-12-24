using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CpyButton : MonoBehaviour {

	public GameObject cpy_panel;
	public GameObject blackPanel;

	public void OnClick() {
		blackPanel.SetActive(true);
		cpy_panel.SetActive(true);
		cpy_panel.GetComponent<Animator>().SetTrigger("In");
	}

}
