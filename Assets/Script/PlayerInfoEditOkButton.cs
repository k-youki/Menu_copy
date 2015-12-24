using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInfoEditOkButton : MonoBehaviour {

	public GameObject edit;
	public GameObject blackPanel;

	public Text player_name;
	public InputField edit_name;
	public Text comment;
	public InputField edit_comment;

	public Toggle morning_tgl;
	public Toggle daytime_tgl;
	public Toggle night_tgl;

	public Image morning_img;
	public Image daytime_img;
	public Image night_img;

	public Color gray = new Color(0.3f, 0.3f, 0.3f, 1f);
	public Color original = new Color(1.0f, 1.0f, 1.0f, 1.0f);

	void Start() {

	}

	public void ReflectionInputField() {
		edit_name.text = player_name.text;
		edit_comment.text = comment.text;
		if( morning_img.color == original)
			morning_tgl.isOn = true;
		else
			morning_tgl.isOn = false;
		if( daytime_img.color == original)
			daytime_tgl.isOn = true;
		else
			daytime_tgl.isOn = false;
		if( night_img.color == original)
			night_tgl.isOn = true;
		else
			night_tgl.isOn = false;
	}

	public void OnClick() {
		edit.GetComponent<Animator>().SetTrigger("Out");

		if( edit_name.text != "" )
			player_name.text = edit_name.text;
		else
			player_name.text = "サマナー";

		comment.text = edit_comment.text;

		if( !morning_tgl.isOn )
			morning_img.color = new Color(0.3f, 0.3f, 0.3f, 1f);
		else
			morning_img.color = new Color(1f, 1f, 1f, 1f);
		if( !daytime_tgl.isOn )
			daytime_img.color = new Color(0.3f, 0.3f, 0.3f, 1f);
		else
			daytime_img.color = new Color(1f, 1f, 1f, 1f);
		if( !night_tgl.isOn )
			night_img.color = new Color(0.3f, 0.3f, 0.3f, 1f);
		else
			night_img.color = new Color(1f, 1f, 1f, 1f);
	}


}
