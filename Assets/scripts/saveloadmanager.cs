using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class saveloadmanager {
	public static void saveplayer(player pemain){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream stream = new FileStream (Application.persistentDataPath + "/player.sav", FileMode.Create);
		
		playerdatas data = new playerdatas(pemain);

		bf.Serialize (stream, data);
		stream.Close();
	}

	public static float[] loadplayer(){
		if (File.Exists (Application.persistentDataPath + "/player.sav")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream stream = new FileStream (Application.persistentDataPath + "/player.sav", FileMode.Open);

			playerdatas data = bf.Deserialize (stream) as playerdatas;

			stream.Close ();
			return data.stats;
		} else {
			Debug.Log ("File DOes Not Exist");
			return new float[7];
		}
	}
}

[Serializable]
public class playerdatas {
	public float[] stats;

	public playerdatas(player pemain){
		stats = new float[7];
		stats [0] = pemain.health.Maxvalue;
		stats [1] = pemain.mana.Maxvalue;
		stats [2] = pemain.attack;
		stats [3] = pemain.defend;
		stats [4] = pemain.speed;
	}
}