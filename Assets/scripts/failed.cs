using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class failed : MonoBehaviour {

	public GameObject loading;
	public Slider slider;

	//public string home;

	public void Base(string gotoscene){
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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
