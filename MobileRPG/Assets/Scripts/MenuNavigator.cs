using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuNavigator : MonoBehaviour
{
    //call all Main Menu buttons 
    public GameObject fight;
    public GameObject magic;
    public GameObject bag;
    public GameObject inspect;

    //call for sub menus
    public GameObject subFight;
    public GameObject subMagic;
    public GameObject subBag;
    public GameObject subInspect;

    private void Start()
    {
        //define the Main Menu buttons
        fight = GameObject.Find("Fight Button");
        magic = GameObject.Find("Magic Button");
        bag = GameObject.Find("Bag Button");
        inspect = GameObject.Find("Interact Button");

        //Difine the SubMenues
        subFight = GameObject.Find("Fight Menu");

        //disable the sub menus on start
        subFight.SetActive(false);
    }


    //a function for when the player taps the fight button
    public void Fight()
    {
        //the main menu buttons are disabled
        fight.SetActive(false);
        magic.SetActive(false);
        bag.SetActive(false);
        inspect.SetActive(false);

        //activate Fight Menu
        subFight.SetActive(true);

    }

    //used for returning to main Menu
    public void Return()
    {
        //Disable Sub Menu
        subFight.SetActive(false);

        //enable all Main Menu Buttons
        fight.SetActive(true);
        magic.SetActive(true);
        bag.SetActive(true);
        inspect.SetActive(true);

    }

    //example of what the buttons would do...
    public void Attack()
    {
        Debug.Log("The Player Attakcs");
    }
}
