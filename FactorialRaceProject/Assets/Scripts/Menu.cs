using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject changeCarScreen;
    [SerializeField] private GameObject[] changeCarColorScreens;
    [SerializeField] private GameObject[] selectorCars;

    private void Start()
    {
        UpdateSelectCar(PlayerPrefs.GetInt("TypeOfCar"));
    }

    public void OpenORCloseChangeCarScreen()
    {
        if (changeCarScreen.activeInHierarchy)
            changeCarScreen.SetActive(false);
        else
            changeCarScreen.SetActive(true);
    }

    public void SelectTypeCar(int typeOfCar)
    {
        PlayerPrefs.SetInt("TypeOfCar", typeOfCar);
        OpenORCloseCarColorScreen(typeOfCar);
    }

    public void SelectColorCar(string colorOfCar)
    {
        PlayerPrefs.SetString("ColorOfCar", colorOfCar);
        OpenORCloseCarColorScreen(PlayerPrefs.GetInt("TypeOfCar"));
        UpdateSelectCar(PlayerPrefs.GetInt("TypeOfCar"));
    }

    private void OpenORCloseCarColorScreen(int typeOfCar)
    {
        changeCarColorScreens[typeOfCar].SetActive(true);
    }

    private void UpdateSelectCar(int typeOfCar)
    {
        Debug.Log(PlayerPrefs.GetInt("TypeOfCar"));
        Debug.Log(PlayerPrefs.GetString("ColorOfCar"));
        selectorCars[typeOfCar].GetComponent<Button>().interactable = false;
    }
}
