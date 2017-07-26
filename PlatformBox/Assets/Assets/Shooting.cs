using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform bullet;
    public Transform bullet2;
    public int BulletForce = 10000;
    public int CurAmmoCount = 10;
    public AudioClip[] clips;
    public AudioClip AudioReloadWeapon;
    public GameObject Reload;
    public GameObject box;
    public Text TextShare;
    public GameObject Pricel;
    AudioSource source;
    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame


    void Update()
    {
        if (TextShare != null)
            TextShare.text = "" + CurAmmoCount;

        if (CrossPlatformInputManager.GetButtonDown("Fire") & CurAmmoCount > 0)
        {
            Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("BulletSpawnPoint").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
            CurAmmoCount = CurAmmoCount - 1;
            source.clip = clips[0];
            source.Play();

        }
        if (CrossPlatformInputManager.GetButtonDown("Fire1") & CurAmmoCount > 0)
        {
            Transform BulletInstance = (Transform)Instantiate(bullet2, GameObject.Find("BulletSpawnPoint").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
            CurAmmoCount = CurAmmoCount - 1;
            source.clip = clips[0];
            source.Play();

        }
        if (CurAmmoCount > 0)
        {
            Cursor.visible = false;

        }
        if (CurAmmoCount <= 0)
        {
            box.SetActive(true);
            Cursor.visible = true;
            Reload.SetActive(true);
            Pricel.SetActive(false);


        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bulled"))
        {
            CurAmmoCount = CurAmmoCount - 1;
        }
    }
}