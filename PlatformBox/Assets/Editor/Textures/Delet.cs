using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delet : MonoBehaviour {
public int Box = 20;
public GameObject Ochki;
public GameObject Vine;
void OnTriggerEnter(Collider other){
    if(other.CompareTag("Box")){
        Ochki.SetActive(true);
		
    }
}
void OnTriggerExit(Collider other){
    if(other.CompareTag("Box")){
        Ochki.SetActive(false);
		Box = Box - 1;
    }
}
void Update() {
	if(Box <= 0){
		Vine.SetActive(true);
		Application.LoadLevel ("2");
	}

}
}