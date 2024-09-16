using UnityEngine;
using UnityEngine.UI;

public class MainPage : MonoBehaviour
{
    [SerializeField] private Button voyageButton;

    //Adds functionality to the buttons clicks when the page is made active
    private void OnEnable()
    {
        voyageButton.onClick.AddListener(MenuManager.Instance.OpenVoyagePage);
    }

    //Removes functionality to the buttons clicks when the page is not active
    private void OnDisable()
    {
        voyageButton.onClick.RemoveListener(MenuManager.Instance.OpenVoyagePage);
    }
}
