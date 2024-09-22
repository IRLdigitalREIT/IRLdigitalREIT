using UnityEngine;
using UnityEngine.UI;
public class InventoryPage : MonoBehaviour
{
    [SerializeField] private Button backButton;

    //Adds functionality to the buttons clicks when the page is made active
    private void OnEnable()
    {
        backButton.onClick.AddListener(MenuManager.Instance.OpenMainPage);
    }

    //Removes functionality to the buttons clicks when the page is not active
    private void OnDisable()
    {
        backButton.onClick.RemoveListener(MenuManager.Instance.OpenMainPage);
    }
}
