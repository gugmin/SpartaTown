using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text Id;

    void Update()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 10)
            button.GetComponent<Button>().interactable = false;
        else
            button.GetComponent<Button>().interactable = true;
    }

    public void IdName()
    {
        Id.text = inputField.text;
    }
}
