using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level5clear : MonoBehaviour {
	public GameObject loading;
	public Slider slider;

	//public string home;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("clear",5);
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
