using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBoom : MonoBehaviour {
public GameObject Robot;
public GameObject Bomba;
public int ent = 3;

void OnCollisionEnter(Collision Col)
 {


  if (Col.gameObject.name == "Bullet(Clone)") 
  {

   ent = ent - 1;

  } 
   
}

void Update () {
 if (ent <= 0){
   gameObject.GetComponent<SphereCollider>().enabled = false;
   Robot.SetActive(false);
   Bomba.SetActive(true);
   

 }
}
}
