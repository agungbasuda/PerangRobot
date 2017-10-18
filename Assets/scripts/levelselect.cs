using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelselect : MonoBehaviour {

	public GameObject loading;
	public Slider slider;

	//public string level1;
	public Button btnlv1;
	public GameObject bgclear1;
	public GameObject clear1;

	//public string level2;
	public Button btnlv2;
	public GameObject bgclear2;
	public GameObject clear2;
	public GameObject lock2;

	//public string level3;
	public Button btnlv3;
	public GameObject bgclear3;
	public GameObject clear3;
	public GameObject lock3;

	//public string level4;
	public Button btnlv4;
	public GameObject bgclear4;
	public GameObject clear4;
	public GameObject lock4;

	//public string level5;
	public Button btnlv5;
	public GameObject bgclear5;
	public GameObject clear5;
	public GameObject lock5;

	//public string home;

	public void Level1(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Level2(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Level3(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Level4(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Level5(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Back(string gotoscene){
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

	public void Start(){
		int clear = PlayerPrefs.GetInt ("clear");
		if (clear == 1) {
			btnlv1.interactable = true;
			btnlv2.interactable = true;
			btnlv3.interactable = false;
			btnlv4.interactable = false;
			btnlv5.interactable = false;

			lock2.SetActive (false);
			lock3.SetActive (true);
			lock4.SetActive (true);
			lock5.SetActive (true);

			bgclear1.SetActive (true);
			clear1.SetActive (true);
			bgclear2.SetActive (false);
			clear2.SetActive (false);
			bgclear3.SetActive (false);
			clear3.SetActive (false);
			bgclear4.SetActive (false);
			clear4.SetActive (false);
			bgclear5.SetActive (false);
			clear5.SetActive (false);
		} else if (clear == 2) {
			btnlv1.interactable = true;
			btnlv2.interactable = true;
			btnlv3.interactable = true;
			btnlv4.interactable = false;
			btnlv5.interactable = false;

			lock2.SetActive (false);
			lock3.SetActive (false);
			lock4.SetActive (true);
			lock5.SetActive (true);

			bgclear1.SetActive (true);
			clear1.SetActive (true);
			bgclear2.SetActive (true);
			clear2.SetActive (true);
			bgclear3.SetActive (false);
			clear3.SetActive (false);
			bgclear4.SetActive (false);
			clear4.SetActive (false);
			bgclear5.SetActive (false);
			clear5.SetActive (false);
		} else if (clear == 3) {
			btnlv1.interactable = true;
			btnlv2.interactable = true;
			btnlv3.interactable = true;
			btnlv4.interactable = true;
			btnlv5.interactable = false;

			lock2.SetActive (false);
			lock3.SetActive (false);
			lock4.SetActive (false);
			lock5.SetActive (true);

			bgclear1.SetActive (true);
			clear1.SetActive (true);
			bgclear2.SetActive (true);
			clear2.SetActive (true);
			bgclear3.SetActive (true);
			clear3.SetActive (true);
			bgclear4.SetActive (false);
			clear4.SetActive (false);
			bgclear5.SetActive (false);
			clear5.SetActive (false);
		} else if (clear == 4) {
			btnlv1.interactable = true;
			btnlv2.interactable = true;
			btnlv3.interactable = true;
			btnlv4.interactable = true;
			btnlv5.interactable = true;

			lock2.SetActive (false);
			lock3.SetActive (false);
			lock4.SetActive (false);
			lock5.SetActive (false);

			bgclear1.SetActive (true);
			clear1.SetActive (true);
			bgclear2.SetActive (true);
			clear2.SetActive (true);
			bgclear3.SetActive (true);
			clear3.SetActive (true);
			bgclear4.SetActive (true);
			clear4.SetActive (true);
			bgclear5.SetActive (false);
			clear5.SetActive (false);
		} else if (clear == 5) {
			bgclear1.SetActive (true);
			clear1.SetActive (true);
			bgclear2.SetActive (true);
			clear2.SetActive (true);
			bgclear3.SetActive (true);
			clear3.SetActive (true);
			bgclear4.SetActive (true);
			clear4.SetActive (true);
			bgclear5.SetActive (true);
			clear5.SetActive (true);
		} else {
			btnlv1.interactable = true;
			btnlv2.interactable = false;
			btnlv3.interactable = false;
			btnlv4.interactable = false;
			btnlv5.interactable = false;

			lock2.SetActive (true);
			lock3.SetActive (true);
			lock4.SetActive (true);
			lock5.SetActive (true);

			bgclear1.SetActive (false);
			clear1.SetActive (false);
			bgclear2.SetActive (false);
			clear2.SetActive (false);
			bgclear3.SetActive (false);
			clear3.SetActive (false);
			bgclear4.SetActive (false);
			clear4.SetActive (false);
			bgclear5.SetActive (false);
			clear5.SetActive (false);
		}
	}
}