//Author: Matthew Villa
//Date: September 18, 2022
//This is my own work
//The purpose of this script is to open and close the main menu screen.
//This script is to be attached to the "Menu Opener", a chaild of the player.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOperator : MonoBehaviour
{
    public GameObject gameMenu;
    public bool menuOpen;

    // Start is called before the first frame update
    void Start()
    {
        gameMenu = GameObject.Find("Main Menu");
        gameMenu.SetActive(false);
        menuOpen = false;
    }

    public void Update()
    {
        //for testing on PC
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ToggleMenu();
        }

        //For mobile purposes
        if (Input.touchCount > 0 && Input.GetTouch(0).tapCount == 2)
        {
            ToggleMenu();
        }
    }


    public void ToggleMenu()
    {
        Debug.Log("Menu Button Clicked");
        if (menuOpen == false)
        {
            gameMenu.SetActive(true);
            menuOpen = true;
        }
        else
        {
            gameMenu.SetActive(false);
            menuOpen = false;
        }
    }
}
