using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Load : MonoBehaviour {
public float progresslvl;
public string filename;
public GameObject zamok1;
public GameObject v1;
public GameObject openlvl1;
public GameObject zamok2;
public GameObject openlvl2;
public GameObject zamok3;
public GameObject openlvl3;
	// Use this for initialization
	void Start () {
		StreamReader streamReader = new StreamReader(filename);
		if(streamReader != null){
			while (!streamReader.EndOfStream)
			{
				progresslvl = System.Convert.ToSingle(streamReader.ReadLine());
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(progresslvl >= 1 ){
		openlvl1.SetActive(true);
		v1.SetActive(true);
		zamok1.SetActive(false);
		
		}
		if(progresslvl >= 2 ){
		openlvl2.SetActive(true);
		zamok2.SetActive(false);
		
		}
		if(progresslvl >= 3 ){
		openlvl3.SetActive(true);
		zamok3.SetActive(false);
		
		
	}
	}
}

