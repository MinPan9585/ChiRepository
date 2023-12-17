using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page3Btn3 : MonoBehaviour
{
    public GameObject page31;
    public GameObject page32;
    public GameObject page33;
    public GameObject page34;

    public void ShowPage31()
    {
        page31.SetActive(false);
        page32.SetActive(false);
        page33.SetActive(true);
        page34.SetActive(false);
    }
}
