using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject gameOverUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
}
