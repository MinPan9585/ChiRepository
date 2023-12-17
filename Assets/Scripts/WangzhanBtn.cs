using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WangzhanBtn : MonoBehaviour
{
    public GameObject page2;
    public GameObject page1;

    public void ShowPage2()
    {
        page2.SetActive(true);
        page1.SetActive(false);
    }
}
