using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstStart : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("TypeOfCar"))
            PlayerPrefs.SetInt("TypeOfCar", 0);

        if (!PlayerPrefs.HasKey("ColorOfCar"))
            PlayerPrefs.SetString("ColorOfCar", "Black");
    }
}
