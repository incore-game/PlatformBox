using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
public GameObject platforma1;
public GameObject platforma2;
void OnCollisionEnter(Collision Col)
 {


  if (Col.gameObject.name == "Bullet(Clone)") 
  {

   platforma1.SetActive(false);
   platforma2.SetActive(true);

  } 
 }

}