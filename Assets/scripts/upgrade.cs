using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	
using UnityEngine.UI;

public class upgrade : MonoBehaviour {
	public GameObject loading;
	public Slider slider;

	public AudioSource bunyi;

	public GameObject clear;

	public Text cost;

	public Button apgret;

	//public string home;

	public Text lepel;
	public Text duid;

	public Text hp;
	public Text mp;
	public Text atk;
	public Text def;
	public Text spd;

	private int level;
	private int money;

	void Start () {
		level = PlayerPrefs.GetInt ("lvl");
		money = PlayerPrefs.GetInt ("money");
	}

	public void penced(){
		bunyi.Play ();
		if (level == 2) {
			money = money - 10000;
			PlayerPrefs.SetInt ("lvl", 3);
			PlayerPrefs.SetInt ("money", money);
			level = 3;
		} else if (level == 3) {
			money = money - 100000;
			PlayerPrefs.SetInt ("lvl", 4);
			PlayerPrefs.SetInt ("money", money);
			level = 4;
		} else if (level == 4) {
			money = money - 1000000;
			PlayerPrefs.SetInt ("lvl", 5);
			PlayerPrefs.SetInt ("money", money);
			level = 5;
		} else {
			money = money - 1000;
			PlayerPrefs.SetInt ("lvl", 2);
			PlayerPrefs.SetInt ("money", money);
			level = 2;
		}
	}

	public void back(string gotoscene){
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

	void Update(){
		duid.text = money.ToString ();

		if(Input.GetKey(KeyCode.K)){
			level = PlayerPrefs.GetInt ("lvl");
			money = PlayerPrefs.GetInt ("money");
			duid.text = "0";
			lepel.text = "1";
			PlayerPrefs.SetInt ("clear", 0);
			PlayerPrefs.SetInt ("lvl", 1);
			PlayerPrefs.SetInt ("money", 0);
		}

		if(Input.GetKey(KeyCode.L)){
			level = PlayerPrefs.GetInt ("lvl");
			money = PlayerPrefs.GetInt ("money");
			duid.text = "999999";
			lepel.text = "5";
			PlayerPrefs.SetInt ("lvl", 5);
			PlayerPrefs.SetInt ("money", 999999);
		}

		if (level == 2) {
			clear.SetActive (false);
			cost.text = "10.000";
			lepel.text = "3";
			hp.text = "1000";
			mp.text = "200";
			atk.text = "10";
			def.text = "5";
			spd.text = "70";

			if (money < 10000) {
				apgret.interactable = false;
			}
		} else if (level == 3) {
			clear.SetActive (false);
			cost.text = "100.000";
			lepel.text = "4";
			hp.text = "10.000";
			mp.text = "250";
			atk.text = "100";
			def.text = "10";
			spd.text = "80";

			if (money < 100000) {
				apgret.interactable = false;
			}
		} else if (level == 4) {
			clear.SetActive (false);
			cost.text = "1.000.000";
			lepel.text = "5";
			hp.text = "100.000";
			mp.text = "300";
			atk.text = "1000";
			def.text = "100";
			spd.text = "90";

			if (money < 1000000) {
				apgret.interactable = false;
			}
		} else if (level == 5) {
			clear.SetActive (true);
			cost.text = "0";
			lepel.text = "5";
			hp.text = "100000";
			mp.text = "300";
			atk.text = "1000";
			def.text = "100";
			spd.text = "90";

			apgret.interactable = false;
		} else {
			clear.SetActive (false);
			cost.text = "1.000";
			lepel.text = "2";
			hp.text = "500";
			mp.text = "150";
			atk.text = "5";
			def.text = "1";
			spd.text = "60";

			if (money < 1000) {
				apgret.interactable = false;
			}
		}
	}
}
