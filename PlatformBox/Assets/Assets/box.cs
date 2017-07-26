using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
public AudioClip[] clips;
AudioSource source;

 void Start () {
 source = GetComponent<AudioSource>();
 }




 void OnCollisionEnter(Collision Col)
 {


  if (Col.gameObject.name == "Platforma") 
  {

   source.clip = clips[0];
   source.Play();

  } 
 }


}﻿
