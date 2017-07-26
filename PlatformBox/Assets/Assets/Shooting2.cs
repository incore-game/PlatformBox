using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Shooting2 : MonoBehaviour
{
    public Transform bullet;
    public int BulletForce = 5000;
    public int CurAmmoCount = 10;
    public AudioClip AudioFire;
    public AudioClip AudioReloadWeapon;
    public GameObject text;
    public GameObject Reload;
	public float repeat_time;
	public float curr_time;
    // Use this for initialization
    void Start()
    {
          curr_time = repeat_time * 5f;
    }
    // Update is called once per frame
    void Update()
    {
		curr_time -= Time.deltaTime;
        if (curr_time <= 0)
        {
            Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("BulletSpawnPoint2").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
            CurAmmoCount = CurAmmoCount - 1;
			curr_time = repeat_time * 5f;
        }
        if (CurAmmoCount > 0)
        {
            Cursor.visible = false;

        }
        if (CurAmmoCount <= 0)
        {
            text.SetActive(true);
            Cursor.visible = true;
            Reload.SetActive(true);


        }
    }
    void OnGUI()
    {
        GUI.skin.label.fontSize = 70;
        GUI.contentColor = Color.red;
        GUI.Label(new Rect(1150, 70, 500, 500), "" + CurAmmoCount);
    }
}