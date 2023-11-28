using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }

    private void Update()
    {
        if (playerName.Length > 1 && 11 > playerName.Length && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    public void InputName()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
        SceneManager.LoadScene("GameScene");
    }
}
