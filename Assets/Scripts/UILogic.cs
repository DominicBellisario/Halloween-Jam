using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;

public class UILogic : MonoBehaviour
{
    [SerializeField] CanvasGroup losePanel;
    [SerializeField] CanvasGroup winPanel;

    private void OnEnable()
    {
        PlayerCollision.PlayerFallsInPit += ShowLoseScreen;
        SoulLogic.SoulShattered += ShowLoseScreen;
        //LineLogic.SoulLineBroke += ShowLoseScreen;
        SoulLogic.SoulInElevator += ShowWinScreen;
    }
    private void OnDisable()
    {
        PlayerCollision.PlayerFallsInPit -= ShowLoseScreen;
        SoulLogic.SoulShattered -= ShowLoseScreen;
        //LineLogic.SoulLineBroke -= ShowLoseScreen;
        SoulLogic.SoulInElevator -= ShowWinScreen;
    }

    // activate the lose panel
    private void ShowLoseScreen()
    {
        losePanel.alpha = 1.0f;
        losePanel.blocksRaycasts = true;
        losePanel.interactable = true;
        Time.timeScale = 0f;
    }

    // actovate the win panel
    private void ShowWinScreen()
    {
        winPanel.alpha = 1.0f;
        winPanel.blocksRaycasts = true;
        winPanel.interactable = true;
        Time.timeScale = 0f;
    }
}
