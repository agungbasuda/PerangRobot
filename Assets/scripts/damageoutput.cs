using UnityEngine;
using System.Collections;

public class damageoutput : MonoBehaviour {

	public Animator animasi;

	//public float lifetime2;

	// Use this for initialization
	void Start () {
		AnimatorClipInfo[] clipinfo = animasi.GetCurrentAnimatorClipInfo (0);
		Destroy (gameObject, clipinfo[0].clip.length);
	}
	
	// Update is called once per frame
	void Update () {
		//lifetime2 -= Time.deltaTime;

		//if(lifetime2 <= 0){
		//	Destroy (gameObject);
		//}

	}
}
