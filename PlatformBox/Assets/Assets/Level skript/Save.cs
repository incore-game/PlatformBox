using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour {
public string filename;	
public int progresslvl;



	// Use this for initialization
	void Update () {
		StreamWriter sw = new StreamWriter (filename);
		sw.WriteLine(progresslvl);
		sw.Close();
	}
	
	// Update is called once per frame
	
}

