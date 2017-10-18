using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	
using UnityEngine.UI;

public class home : MonoBehaviour {

	public GameObject loading;
	public Slider slider;

	//public string adventure;
	//public string survival;
	//public string upgrade;

	public Text lepel;
	public Text duid;

	public Text hp;
	public Text mp;
	public Text atk;
	public Text def;
	public Text spd;

	private int level;
	private int money;

	public void Adventure(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Survival(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Upgrade(string gotoscene){
		StartCoroutine (LoadAsynchronously(gotoscene));
	}
	public void Quit(){
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

	void Start () {
		level = PlayerPrefs.GetInt ("lvl");
		lepel.text = level.ToString ();

		money = PlayerPrefs.GetInt ("money");
		duid.text = money.ToString ();
	}

	void Update(){
		if(Input.GetKey(KeyCode.K)){
			duid.text = "0";
			lepel.text = "1";
			PlayerPrefs.SetInt ("clear", 0);
			PlayerPrefs.SetInt ("lvl", 1);
			PlayerPrefs.SetInt ("money", 0);
		}

		if(level == 2){
			hp.text = "500";
			mp.text = "150";
			atk.text = "5";
			def.text = "1";
			spd.text = "60";
		}
		else if(level == 3){
			hp.text = "1000";
			mp.text = "200";
			atk.text = "10";
			def.text = "5";
			spd.text = "70";
		}
		else if(level == 4){
			hp.text = "10000";
			mp.text = "250";
			atk.text = "100";
			def.text = "10";
			spd.text = "80";
		}
		else if(level == 5){
			hp.text = "100000";
			mp.text = "300";
			atk.text = "1000";
			def.text = "100";
			spd.text = "90";
		}
		else{
			hp.text = "100";
			mp.text = "100";
			atk.text = "1";
			def.text = "0";
			spd.text = "50";
		}
	}
}
