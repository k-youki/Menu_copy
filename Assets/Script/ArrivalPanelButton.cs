using UnityEngine;
using System.Collections;

public class ArrivalPanelButton : MonoBehaviour {

	public GameObject arrival_panel;
	public GameObject blackPanel;

	public void OnClick() {
		//this.GetComponent<Animator>().SetTrigger("Clicked");
		blackPanel.SetActive(true);
		//blackPanel.GetComponent<Animator>().SetTrigger("ChangeScreen");
		arrival_panel.SetActive(true);
		arrival_panel.GetComponent<Animator>().SetTrigger("In");
		//StartCoroutine(Change());

	}
}
