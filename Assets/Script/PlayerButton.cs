using UnityEngine;
using System.Collections;

public class PlayerButton : MonoBehaviour {

	public GameObject menu;
	public GameObject blackPanel;
	public GameObject player;
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
		player.SetActive(true);
		blackPanel.GetComponent<Animator>().SetTrigger("Akiraten");
		anim_panel.GetComponent<Animator>().SetTrigger("In");
		title_bord.GetComponent<Animator>().SetTrigger("In");
		iTween.Stop();
		moveMessage.scroll_txt = "プレイヤー情報の確認と設定ができます。　フレンドにアピールするコメントを設定しましょう。";
		moveMessage.last_x = last_x;
		moveMessage.init_txt();
	}

}
