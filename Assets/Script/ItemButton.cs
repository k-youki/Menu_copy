using UnityEngine;
using System.Collections;

public class ItemButton : MonoBehaviour {

	public GameObject menu;
	public GameObject blackPanel;
	public GameObject item_screen;
	public GameObject anim_panel;
	public GameObject title_bord;
	public MoveMessage moveMessage;
	public float last_x;

	public void OnClick() {
		blackPanel.SetActive(true);
		blackPanel.GetComponent<Animator>().SetTrigger("Dim");
		StartCoroutine(Change());
	}

	IEnumerator Change() {
		yield return new WaitForSeconds(0.4f);
		menu.SetActive(false);
		item_screen.SetActive(true);
		blackPanel.GetComponent<Animator>().SetTrigger("Akiraten");
		//anim_panel.GetComponent<Animator>().SetTrigger("In");
		title_bord.GetComponent<Animator>().SetTrigger("In");
		iTween.Stop();
		moveMessage.scroll_txt = "アイテムページです。";
		moveMessage.last_x = last_x;
		moveMessage.init_txt();
	}

}
