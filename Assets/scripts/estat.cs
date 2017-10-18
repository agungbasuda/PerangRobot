using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class estat{

	[SerializeField]
	private ebarscript ebar;

	[SerializeField]
	public float emaxvalue;

	[SerializeField]
	public float ecurvalue;

	public float ECurvalue{
		get{ return ecurvalue;
		}
		set{ 
			this.ecurvalue = Mathf.Clamp(value,0,EMaxvalue);
			ebar.Value = ecurvalue;
		}
	}

	public float EMaxvalue{
		get{ return emaxvalue;
		}
		set{ 
			this.emaxvalue = value;
			ebar.emaxvalue = value;
		}
	}

	public void Initialize(){
		this.EMaxvalue = emaxvalue;
		this.ECurvalue = ecurvalue;
	}

}
