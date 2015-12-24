using UnityEngine;
using System.Collections;

public class EditButton : MonoBehaviour {

	public GameObject edit;
	public GameObject blackPanel;
	public PlayerInfoEditOkButton oKButton;

	public void OnClick() {
		//this.GetComponent<Animator>().SetTrigger("Clicked");
		blackPanel.SetActive(true);
		//blackPanel.GetComponent<Animator>().SetTrigger("ChangeScreen");
		edit.SetActive(true);
		edit.GetComponent<Animator>().SetTrigger("In");
		//StartCoroutine(Change());
		oKButton.ReflectionInputField();
	}
}
