using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButton : MonoBehaviour
{
    public GameObject phone;

    public void ShowPhone()
    {
        phone.SetActive(true);
    }
}
