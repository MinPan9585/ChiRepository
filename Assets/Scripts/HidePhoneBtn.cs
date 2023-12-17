using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePhoneBtn : MonoBehaviour
{
    public GameObject phone;

    public void HidePhone()
    {
        phone.SetActive(false);
    }
}
