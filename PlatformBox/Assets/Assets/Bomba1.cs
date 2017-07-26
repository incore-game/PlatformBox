using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba1 : MonoBehaviour {
public GameObject obolochka; 
public GameObject vzriv;
	// Use this for initialization
	void Start () {
		
	}
	 void OnCollisionEnter(Collision Col)
 {


  if (Col.gameObject.name == "Bullet(Clone)") 
  {
   obolochka.SetActive(false);
   vzriv.SetActive(true);

		
	}
	if (Col.gameObject.name == "Bomba") 
  {
   obolochka.SetActive(false);
   vzriv.SetActive(true);

		
	}
		if (Col.gameObject.name == "BOX") 
  {
   obolochka.SetActive(false);
   vzriv.SetActive(true);

		
	}
}
}
