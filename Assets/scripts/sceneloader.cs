using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneloader : MonoBehaviour {

	public GameObject loading;
	public Slider slider;

	public void loadlevel(string sceneIndex){
		StartCoroutine (LoadAsynchronously(sceneIndex));
	}

	IEnumerator LoadAsynchronously(string sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);

		loading.SetActive (true);

		while(!operation.isDone){
			float progress = Mathf.Clamp01 (operation.progress / .9f);
			slider.value = progress;

			yield return null;
		}
	}

}
