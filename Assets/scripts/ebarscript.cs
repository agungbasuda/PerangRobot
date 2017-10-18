﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ebarscript : MonoBehaviour {

	private float fillamount;

	[SerializeField]
	private float lerpspeed;

	[SerializeField]
	private float secondlerpspeed;

	[SerializeField]
	private Image content;

	[SerializeField]
	private Image secondcontent;

	public float emaxvalue{ get; set;}

	public float Value{
		set{ 
			fillamount = Map (value, 0, emaxvalue, 0, 1);
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		HandleBar ();
	}

	private void HandleBar(){
		if (fillamount != content.fillAmount) {
			content.fillAmount = Mathf.Lerp(content.fillAmount,fillamount,Time.deltaTime*lerpspeed);
			secondcontent.fillAmount = Mathf.Lerp(secondcontent.fillAmount,fillamount,Time.deltaTime*secondlerpspeed);
		}
	}

	private float Map(float value, float inMin,float inMax, float outMin, float outMax)	{
		return(value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
