using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public GameObject homeobj, levelobj, playobj;
    int lvlno = 0, TotalLevel = 0;
    public Button[] BtnAry;
    public Sprite tick;

    private void OnEnable()
    {
        lvlno = PlayerPrefs.GetInt("LevelNo", 1);
        TotalLevel = PlayerPrefs.GetInt("TotalLevel", 0);

        for(int i=0;i<=TotalLevel;i++)
        {
            BtnAry[i].interactable = true;
            BtnAry[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
           
            if(i < TotalLevel)
            {
                if (PlayerPrefs.HasKey("skip_" + (i + 1)))
                {
                    BtnAry[i].GetComponent<Image>().sprite = null;
                }
                else
                {
                    BtnAry[i].GetComponent<Image>().sprite = tick;
                }
                //BtnAry[i].GetComponent<Image>().sprite = tick;
            }
            else
            {
                BtnAry[i].GetComponent<Image>().sprite = null; 
            }
        }
    }
    public void onClickLevelNo(int n)
    {
        PlayerPrefs.SetInt("LevelNo", n);
        levelobj.SetActive(false);
        playobj.SetActive(true);
    }

}
