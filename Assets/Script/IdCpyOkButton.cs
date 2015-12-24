using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IdCpyOkButton : MonoBehaviour {

	public GameObject copyScreen;
	public GameObject blackPanel;

	public void OnClick() {
		blackPanel.SetActive(false);
		copyScreen.GetComponent<Animator>().SetTrigger("Out");
	}


}
