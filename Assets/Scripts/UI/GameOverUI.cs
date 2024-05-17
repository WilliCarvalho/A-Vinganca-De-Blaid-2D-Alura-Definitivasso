using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private Button MenuButton;

    private void Awake()
    {
        restartButton.onClick.AddListener(RestartGame);
        MenuButton.onClick.AddListener(GoToMenu);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
