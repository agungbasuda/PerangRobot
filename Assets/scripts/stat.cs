using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class stat{

	[SerializeField]
	private barscript bar;

	[SerializeField]
	private float maxvalue;

	[SerializeField]
	private float curvalue;

	public float Curvalue{
		get{ return curvalue;
		}
		set{
			this.curvalue = Mathf.Clamp(value,0,Maxvalue);
			bar.Value = curvalue;
		}
	}
		
	public float Maxvalue{
		get{ return maxvalue;
		}
		set{ 
			this.maxvalue = value;
			bar.maxvalue = value;
		}
	}

	public void Initialize(){
		this.Maxvalue = maxvalue;
		this.Curvalue = curvalue;
	}
}
