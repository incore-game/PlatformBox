using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxbreck : MonoBehaviour {
public GameObject MainBox;
public GameObject Box0;
public GameObject Box1;
public GameObject Box2;
public GameObject Box3;
public GameObject Box4;
public GameObject Box5;
public GameObject Box6;
public GameObject Box7;
public GameObject Box8;
public GameObject Box9;
public GameObject Box10;
public int ent = 3;
public AudioClip[] clips;
AudioSource source;

   void Start()
    {
        source = GetComponent<AudioSource>();
    }
	
void OnCollisionEnter(Collision Col)
 {


  if (Col.gameObject.name == "Bullet(Clone)") 
  {

   ent = ent - 1;
   source.clip = clips[0];
   source.Play();

  } 
    if (ent <= 0){
   
   MainBox.GetComponent<BoxCollider>().enabled = false;
   Box0.SetActive(false);
   Box1.SetActive(true);
   Box2.SetActive(true);
   Box3.SetActive(true);
   Box4.SetActive(true);
   Box5.SetActive(true);
   Box6.SetActive(true);
   Box7.SetActive(true);
   Box8.SetActive(true);
   Box9.SetActive(true);
   Box10.SetActive(false);
   
 }
}

}
