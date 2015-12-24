using UnityEngine;
using System.Collections;

public class OptionButton : MonoBehaviour {

	public GameObject menu;
	public GameObject blackPanel;
	public GameObject option;
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
		option.SetActive(true);
		blackPanel.GetComponent<Animator>().SetTrigger("Akiraten");
		anim_panel.GetComponent<Animator>().SetTrigger("In");
		title_bord.GetComponent<Animator>().SetTrigger("In");
		iTween.Stop();
		moveMessage.scroll_txt = "音の設定やプッシュ通知の設定ができます。　プレイスタイルに応じて、遊びやすい設定に調整をしてください";
		moveMessage.last_x = last_x;
		moveMessage.init_txt();
	}

}
