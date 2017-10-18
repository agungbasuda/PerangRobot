using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	
using UnityEngine.UI;

public class mainmenu : MonoBehaviour {

	public GameObject loading;
	public Slider slider;

	//public string home;
	public GameObject kredit;

	public void main(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void credit(){
		kredit.SetActive (true);
	}
	public void closecredit(){
		kredit.SetActive (false);
	}
	public void keluar(){
		Application.Quit ();
	}

	// Use this for initialization
	void Start () {
		kredit.SetActive (false);
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
