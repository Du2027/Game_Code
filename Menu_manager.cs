using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_manager : MonoBehaviour
{
    private GameObject Main_Menu;
    private GameObject Level_Menu;
    private GameObject Level1;
    void Start()
    {
        Main_Menu = GameObject.Find("Menu");
        Level_Menu = GameObject.Find("Levels");
        Level1 = GameObject.Find("Lvl1");

        Level_Menu.SetActive(false);
        Level1.SetActive(false);
    }

    void Update()
    {
        
    }

    public void levels_from_main(){
        Main_Menu.SetActive(false);
        Level_Menu.SetActive(true);
    }

    public void level1_from_levels(){
        Level1.SetActive(true);
        Level_Menu.SetActive(false);
    }

    public void main_menu_from_Lvls(){
        Main_Menu.SetActive(true);
        Level_Menu.SetActive(false);
    }

    public void Quit_Game(){
        Application.Quit();
    }

    
}
