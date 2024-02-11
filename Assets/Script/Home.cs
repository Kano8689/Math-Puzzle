using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public GameObject homeobj, levelobj, playobj;
    //int lvlno = 0;

    public void onClickContinue()
    {
        homeobj.SetActive(false);
        playobj.SetActive(true);
    }

    public void onClickPuzzle()
    {
        homeobj.SetActive(false);
        levelobj.SetActive(true);
    }
}
