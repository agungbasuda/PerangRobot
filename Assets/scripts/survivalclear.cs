using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class survivalclear : MonoBehaviour {
	public GameObject loading;
	public Slider slider;

	//public string home;

	// Use this for initialization
	void Start () {
		int money = PlayerPrefs.GetInt ("money");
		money = money + 1000;
		PlayerPrefs.SetInt ("money", money);
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
