using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause : MonoBehaviour {
	public GameObject loading;
	public Slider slider;

	public GameObject menu;

	//public string home;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			if (Time.timeScale == 1) {
				menu.SetActive (true);
				Time.timeScale = 0;
			}
		}
	}

	public void Resume(){
		Time.timeScale = 1;
		menu.SetActive (false);
	}

	public void Base(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}

	public void Keluar(){
		Application.Quit ();
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
