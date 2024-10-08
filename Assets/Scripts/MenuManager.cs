using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//Menu Manager controls the transition between pages (eg to open new page must close previous page)
public class MenuManager : MonoBehaviour
{
    //Singleton pattern for easy referencing in later scripts
    public static MenuManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //We start the game on the Main menu page later can be changed to the loading page
    private void Start()
    {
        OpenMainPage();
    }

    //References to the individual pages
    //[SerializeField] private LoadingPage loadingPage;
    [SerializeField] private MainPage mainPage;
    [SerializeField] private VoyagePage voyagePage;
    [SerializeField] private InventoryPage inventoryPage;

    //this is repetitive code but it avoids us having to put in a reference of each page in each page
    //this can be made much cleaner using generics and dictionaries 

    //Opens the loading screen page
    public void OpenLoadingPage()
    {
        //loadingPage.gameObject.SetActive(true);
        mainPage.gameObject.SetActive(false);
        voyagePage.gameObject.SetActive(false);
    }

    //Opens the Main home landing page
    public void OpenMainPage()
    {
        mainPage.gameObject.SetActive(true);
        voyagePage.gameObject.SetActive(false);
        inventoryPage.gameObject.SetActive(false);
        //loadingPage.gameObject.SetActive(false);
    }
    //Opens the Inventory page
    public void OpenInventoryPage()
    {
        inventoryPage.gameObject.SetActive(true);
        mainPage.gameObject.SetActive(false);
        //loadingPage.gameObject.SetActive(false);
    }
    //Opens the Voyage page page
    public void OpenVoyagePage()
    {
        voyagePage.gameObject.SetActive(true);
        mainPage.gameObject.SetActive(false);
    }

    
}





