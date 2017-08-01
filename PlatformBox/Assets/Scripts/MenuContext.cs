using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuContext : MonoBehaviour
{
    public GameObject page_main;
    public GameObject page_list;

    public Image Wellpap;
    public List<Sprite> Wellpaps;

    [Space]
    public int page;

    [Space]
    public RectTransform[] groupdlc;
    public RectTransform[] grouplist;
    public ButtonLevel tpl;

    [System.Serializable]
    public class LevelData
    {
        public int Number;
        public string Name;
        public int record;

    }

    [System.Serializable]
    public class GruopData
    {
        public List<LevelData> levels;
    }
    public List<LevelData> levels;

    public List<GruopData> gruops;

    // Use this for initialization
    void Start()
    {
        levels.Clear();
        gruops.ForEach(gruop =>
        {
            gruop.levels.ForEach(lvl =>
            {
                levels.Add(lvl);
            });
        });


        int i = 1;

        foreach (LevelData lvl in levels)
        {

            lvl.Number = i;
            i++;
            lvl.record = PlayerPrefs.GetInt("LevelRecord_" + lvl.Number, 0);
            /*
            for (int i = 0; i < lvl.record; i++)
            {
                if (lvl.stars.Length > i)
                {
                    lvl.stars[i].SetActive(true);
                }
            }*/
        }

        Print();
    }

    public List<GameObject> objs;
    void Print()
    {
        if (page < 1) page = 1;
        int start = (page - 1) * 3;

        if (page <= Wellpaps.Count)
        {
            Wellpap.sprite = Wellpaps[page - 1];
        }
        else
        {
            Debug.LogWarningFormat("Для страницы {0} не задан фон", page);
        }
        int count = objs.Count;
        for (int f = 0; f < count; f++)
        {
            Destroy(objs[f]);
        }
        objs.Clear();

        for (int i = 0; i < 3; i++)
        {
            int g = start + i;
            if (gruops.Count < (g + 1)) break;

            var gruop = gruops[g];

            bool istop = true;

            gruop.levels.ForEach(lvl =>
            {
                ButtonLevel go = Instantiate(tpl, grouplist[i]);
                go.gameObject.transform.localScale = new Vector3(1, 1, 1);
                go.Init(lvl);
                if (lvl.record < 3) istop = false;
                objs.Add(go.gameObject);
            });
            groupdlc[i].gameObject.SetActive(istop);

        }

    }

    public void Play()
    {
        LevelData lvl = levels.Find(x => x.record == 0);
        if (lvl == null)
        {
            return;
        }
        SceneManager.LoadScene(lvl.Name);
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLvls()
    {
        page_main.SetActive(false);
        page_list.SetActive(true);
        page = 0;
        Print();
    }

    public void Next()
    {
        page++;
        Print();
    }

    public void Back()
    {
        page--;
        if (page == 0)
        {
            page_main.SetActive(true);
            page_list.SetActive(false);
        }
        else
        {
            Print();
        }
    }
}