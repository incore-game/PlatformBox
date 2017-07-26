using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Delet : MonoBehaviour
{

    public int mapid;
    public int Box = 20;
    public AudioClip[] clips;
    public GameObject Ochki;
    public GameObject Vine;
    public GameObject Zvezda1;
    public GameObject Zvezda2;
    public GameObject Zvezda3;
    public int z1;
    public int z2;
    public int z3;
    public GameObject Pricel;
    public Texture2D CursorTexture;
    public string filename;
    public int progresslvl;
    public Text TextBox;
    public Shooting shooting_script;
    AudioSource source;

    void Start()
    {
        StreamWriter sw = new StreamWriter(filename);
        sw.WriteLine(progresslvl);
        sw.Close();
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Ochki.SetActive(true);
            Box = Box - 1;
            source.clip = clips[0];
            source.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Ochki.SetActive(false);


        }
    }
    void Update()
    {

        if (TextBox != null)
            TextBox.text = "" + Box;

        if (Box <= 0)
        {
            Vine.SetActive(true);


            Pricel.SetActive(false);
            if (shooting_script.CurAmmoCount >= z1)
            {
                var old = PlayerPrefs.GetInt("LevelRecord_" + mapid, -1);
                if (old<3)
                PlayerPrefs.SetInt("LevelRecord_" + mapid, 3);
                Zvezda1.SetActive(true);
                Zvezda2.SetActive(true);
                Zvezda3.SetActive(true);

            }else
            if (shooting_script.CurAmmoCount >= z2)
            {
                var old = PlayerPrefs.GetInt("LevelRecord_" + mapid, -1);
                if (old < 2)
                    PlayerPrefs.SetInt("LevelRecord_" + mapid, 2);
                Zvezda1.SetActive(true);
                Zvezda2.SetActive(true);

            }else
            if (shooting_script.CurAmmoCount >= z3)
            {
                var old = PlayerPrefs.GetInt("LevelRecord_" + mapid, -1);
                if (old < 1)
                    PlayerPrefs.SetInt("LevelRecord_" + mapid, 1);
                Zvezda1.SetActive(true);
            }
        }
    }
}