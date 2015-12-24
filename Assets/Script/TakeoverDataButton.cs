using UnityEngine;
using System.Collections;

public class TakeoverDataButton : MonoBehaviour {

	public GameObject menu;
	public GameObject blackPanel;
	public GameObject takeover_data;
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
		takeover_data.SetActive(true);
		blackPanel.GetComponent<Animator>().SetTrigger("Akiraten");
		anim_panel.GetComponent<Animator>().SetTrigger("In");
		title_bord.GetComponent<Animator>().SetTrigger("In");
		iTween.Stop();
		moveMessage.scroll_txt = "この端末から他の端末にデータを引き継ぐために必要な、パスワードの設定を行います";
		moveMessage.last_x = last_x;
		moveMessage.init_txt();
	}

}
