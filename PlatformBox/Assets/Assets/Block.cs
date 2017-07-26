using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
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
   if (Col.gameObject.name == "Box") 
  {

   source.clip = clips[0];
   source.Play();

  } 
  if (Col.gameObject.name == "Block") 
  {

   source.clip = clips[0];
   source.Play();

  } 
 }


}﻿