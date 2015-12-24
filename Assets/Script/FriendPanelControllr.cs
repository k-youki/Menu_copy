﻿using UnityEngine;
using System.Collections;

public class FriendPanelControllr : MonoBehaviour 
{
	public bool trans_list_flag;
	public bool trans_waitok_flag;
	public bool trans_serch_flag;

	public GameObject active_plate;

	GameObject list_view;
	GameObject waitok_view;
	GameObject serch_view;

	public GameObject list_plate;
	public GameObject waitok_plate;
	public GameObject serch_plate;

	public GameObject tab_cursor;

	void Start()
	{
		InitFlag();
	}

	void InitFlag()
	{
		trans_list_flag   = false;
		trans_serch_flag  = false;
		trans_waitok_flag = false;
	}

	public void ChangeView()
	{
		active_plate.transform.FindChild("view").gameObject.SetActive( false );
		active_plate.transform.FindChild("ON_plate").gameObject.SetActive( false );

		if ( trans_list_flag ) {
			//リストタブへの遷移
			list_plate.transform.FindChild("view").gameObject.SetActive( true );
			list_plate.transform.FindChild("ON_plate").gameObject.SetActive( true );
			active_plate = list_plate;
			iTween.MoveTo(tab_cursor, iTween.Hash("x", -250, "speed", 1000f, "easetype", iTween.EaseType.linear, "islocal", true));
		} else if ( trans_waitok_flag ) {
			//承認待ちタブへの遷移
			waitok_plate.transform.FindChild("view").gameObject.SetActive( true );
			waitok_plate.transform.FindChild("ON_plate").gameObject.SetActive( true );
			active_plate = waitok_plate;
			iTween.MoveTo(tab_cursor, iTween.Hash("x", 0, "speed", 1000f, "easetype", iTween.EaseType.linear, "islocal", true));
		} else if (  trans_serch_flag ) {
			//検索タブへの遷移
			serch_plate.transform.FindChild("view").gameObject.SetActive( true );
			serch_plate.transform.FindChild("ON_plate").gameObject.SetActive( true );
			active_plate = serch_plate;
			iTween.MoveTo(tab_cursor, iTween.Hash("x", 250, "speed", 1000f, "easetype", iTween.EaseType.linear, "islocal", true));
		}

		InitFlag();
	}

	public void TransListFlagEnabled()
	{
		trans_list_flag = true;
	}

	public void TransWaitOKFlagEnabled()
	{
		trans_waitok_flag = true;
	}

	public void TransSerchFlagEnabled()
	{
		trans_serch_flag = true;
	}
}
