using UnityEngine;
using UnityEngine.UI;

public class MainPage : MonoBehaviour
{
    //These are all basic pages for now with 1 button, they can be expanded in future 
    [SerializeField] private Button voyageButton;
    [SerializeField] private Button inventoryButton;

    //Adds functionality to the buttons clicks when the page is made active
    private void OnEnable()
    {
        voyageButton.onClick.AddListener(MenuManager.Instance.OpenVoyagePage);
        inventoryButton.onClick.AddListener(MenuManager.Instance.OpenInventoryPage);
    }

    //Removes functionality to the buttons clicks when the page is not active
    private void OnDisable()
    {
        voyageButton.onClick.RemoveListener(MenuManager.Instance.OpenVoyagePage);
        inventoryButton.onClick.RemoveListener(MenuManager.Instance.OpenInventoryPage);
    }
}
