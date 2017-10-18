﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level4clear : MonoBehaviour {
	public GameObject loading;
	public Slider slider;

	//public string home;

	// Use this for initialization
	void Start () {
		int money = PlayerPrefs.GetInt ("money");
		money = money + 999500;
		PlayerPrefs.SetInt ("money", money);
	}
	
	// Update is called once per frame
	void Update () {
		int clear = PlayerPrefs.GetInt ("clear");
		if (clear == 5) {
			PlayerPrefs.SetInt ("clear", 5);
		} else {
			PlayerPrefs.SetInt ("clear",4);
		}
	}

	public void Home(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	} 

	IEnumerator LoadAsynchronously(string gotoscene){
		AsyncOperation operation = SceneManager.LoadSceneAsync (gotoscene);
		loading.SetActive (true);
		while(!operation.isDone){

			float progress = Mathf.Clamp01 (operation.progress / .9f);
			slider.value = progress;
			Debug.Log (progress);
			yield return null;
		}
	}
}