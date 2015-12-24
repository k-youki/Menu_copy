using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Footer : MonoBehaviour {

	public GameObject player;
	public GameObject option;
	public GameObject blackPanel;

	public MoveMessage moveMessage;
	public bool animFlg;
	public float last_x;

	public GameObject HomeImg;
	public GameObject BattleImg;
	public GameObject HeroImg;
	public GameObject GachaImg;
	public GameObject ShopImg;
	public GameObject MenuImg;

	public GameObject MenuScrenn;

	public GameObject IncreImg;

	GameObject tmp;

	void Start() {
		animFlg = false;
	}

	public void ClickMenu() {
		if ( IncreImg != MenuImg ){
			IncreImg.GetComponent<Animator>().SetTrigger("Reduction");
			MenuImg.GetComponent<Animator>().SetTrigger("Increase");
			IncreImg = MenuImg;
		}
		if( !animFlg ) {
			animFlg = true;
			blackPanel.SetActive(true);
			blackPanel.GetComponent<Animator>().SetTrigger("Dim");
			StartCoroutine(ChangeMenu());
		}
	}

	IEnumerator ChangeMenu() {
		yield return new WaitForSeconds(0.4f);
		player.SetActive(false);
		option.SetActive(false);
		MenuScrenn.SetActive(true);
		MenuScrenn.GetComponent<Animator>().SetTrigger("Arrival");
		blackPanel.GetComponent<Animator>().SetTrigger("Akiraten");
		iTween.Stop();
		moveMessage.scroll_txt = "解らないことがあったら、ヘルプをタッチしてください。　色々な機能を使って、ゲームをより楽しんでください。";
		moveMessage.last_x = last_x;
		moveMessage.init_txt();
	}

	public void ClickHome() {
			if (IncreImg != HomeImg){
				IncreImg.GetComponent<Animator>().SetTrigger("Reduction");
				HomeImg.GetComponent<Animator>().SetTrigger("Increase");
				IncreImg = HomeImg;
			}
	}

	public void ClickBattle() {
			if (IncreImg != BattleImg){
				IncreImg.GetComponent<Animator>().SetTrigger("Reduction");
				BattleImg.GetComponent<Animator>().SetTrigger("Increase");
				IncreImg = BattleImg;
			}
	}

	public void ClickHero() {
			if (IncreImg != HeroImg){
				IncreImg.GetComponent<Animator>().SetTrigger("Reduction");
				HeroImg.GetComponent<Animator>().SetTrigger("Increase");
				IncreImg = HeroImg;
			}
	}

	public void ClickGacha() {
			if (IncreImg != GachaImg){
				IncreImg.GetComponent<Animator>().SetTrigger("Reduction");
				GachaImg.GetComponent<Animator>().SetTrigger("Increase");
				IncreImg = GachaImg;
			}
	}

	public void ClickShop() {
			if (IncreImg != ShopImg){
				IncreImg.GetComponent<Animator>().SetTrigger("Reduction");
				ShopImg.GetComponent<Animator>().SetTrigger("Increase");
				IncreImg = ShopImg;
			}
	}
}
