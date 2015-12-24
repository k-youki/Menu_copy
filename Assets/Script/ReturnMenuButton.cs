using UnityEngine;
using System.Collections;

public class ReturnMenuButton : MonoBehaviour {

	public GameObject menu;
	public GameObject blackPanel;
	public GameObject option;
	public GameObject title_bord;
	public MoveMessage moveMessage;
	public float last_x = -1075f;

	public void OnClick() {
		blackPanel.SetActive(true);
		blackPanel.GetComponent<Animator>().SetTrigger("Dim");
		title_bord.GetComponent<Animator>().SetTrigger("Out");
		StartCoroutine(Change());
	}

	IEnumerator Change() {
		yield return new WaitForSeconds(0.4f);
		option.SetActive(false);
		menu.SetActive(true);
		menu.GetComponent<Animator>().SetTrigger("Arrival");
		blackPanel.GetComponent<Animator>().SetTrigger("Akiraten");
		iTween.Stop();
		moveMessage.scroll_txt = "解らないことがあったら、ヘルプをタッチしてください。　色々な機能を使って、ゲームをより楽しんでください。";
		moveMessage.last_x = last_x;
		moveMessage.init_txt();
	}

}
