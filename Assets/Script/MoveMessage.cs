using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MoveMessage : MonoBehaviour {

	public float last_x;
	public string scroll_txt;

	// Use this for initialization
	void Start () {
			scroll_txt = "解らないことがあったら、ヘルプをタッチしてください。　色々な機能を使って、ゲームをより楽しんでください。";
			init_txt();
	}

	public void init_txt( ) {
		this.GetComponent<Text>().text = scroll_txt;
		transform.localPosition = new Vector3(315f, 65.1f, 0f);
		ScrollHandler();
	}

	private void InstHandler(  ) {
		transform.localPosition = new Vector3(1106, 65.1f, 0f);
		DashHandler();
	}

	private void DashHandler(  ) {
		iTween.MoveTo(gameObject, iTween.Hash("x", 315,  "delay", 3, "speed", 1000f, "easetype", iTween.EaseType.linear, "islocal", true, "oncomplete", "ScrollHandler"));
	}

	private void ScrollHandler(  ) {
		iTween.MoveTo(gameObject, iTween.Hash("x", last_x, "delay", 3, "speed", 100f, "easetype", iTween.EaseType.linear, "islocal", true, "oncomplete", "InstHandler"));
	}

}
