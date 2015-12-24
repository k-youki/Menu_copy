using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class input_comment : MonoBehaviour {

	public Text player_name;
	public Text edit_name;
	public Text comment;
	public Text edit_comment;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void PressOkButton () {
		player_name.text = edit_name.text;
		comment.text = edit_comment.text;
	}
}
