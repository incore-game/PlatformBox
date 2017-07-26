using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour {

 public GameObject target;
    public float sens;
 
    void Update () {
        float x = 0;
        float y = 0;
 
#if UNITY_ANDROID
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //user pressed back key
            Application.Quit();
        }
        if (Input.touchCount > 0)
        {
            x = -Input.touches[0].deltaPosition.x;
            y = Input.touches[0].deltaPosition.y;
        }
#endif
        if (x != 0) target.transform.Rotate(Vector3.up,    x * sens, Space.World);
        if (y != 0) target.transform.Rotate(Vector3.right, y * sens, Space.World);
    }
}