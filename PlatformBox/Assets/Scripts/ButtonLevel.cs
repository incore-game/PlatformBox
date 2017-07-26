using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour {

    public Text Name;
    public string Lvlname;

    public GameObject[] stars;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenLvl()
    {
        SceneManager.LoadScene(Lvlname);
    }

    public void Init(MenuContext.LevelData data)
    {
        Name.text = data.Number.ToString();
        Lvlname = data.Name;
        for (int i = 0; i < data.record; i++)
        {
            if (stars.Length > i)
            {
                stars[i].SetActive(true);
            }
        }
    }
}
