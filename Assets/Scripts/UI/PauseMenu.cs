using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject eventSystem;
    public GameObject SavePanel;

    private bool pausingIsAllowed = true;
    public bool PausingIsAllowed
    {
        get
        {
            return pausingIsAllowed;
        }
        set
        {
            if (!value)
            {
                SwapActiveState(false);
            }
            pausingIsAllowed = value;
        }
    }

    Image backgroundImage;
    CanvasGroup canvasGroup;

    private void Awake()
    {
        backgroundImage = GetComponent<Image>();
        canvasGroup = GetComponentInParent<CanvasGroup>();
        GameIsPaused = backgroundImage.enabled;
        SwapActiveState(GameIsPaused);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameIsPaused)
        {
            SwapActiveState(true);
        }
    }

    /// <summary>
    /// Swaps the active state of the pause menu
    /// </summary>
    /// <param name="state">True means the pause menu will be activated, false means the pause menu will be deactivated.</param>
    void SwapActiveState(bool state)
    {
		if (state && pausingIsAllowed)
		{
            backgroundImage.enabled = true;
            MainPauseMenu.SetActive(true);
            eventSystem.SetActive(true);

            Time.timeScale = 0f;

            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;

            GameIsPaused = true;
        }
        else if (!state)
        {
            backgroundImage.enabled = false;
            MainPauseMenu.SetActive(false);
            eventSystem.SetActive(false);

            Time.timeScale = 1f;

            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;

            GameIsPaused = false;
        }
    }

    public void Resume()
    {
        SwapActiveState(false);
    }

    public void SaveGame()
    {
        SavePanel.SetActive(true);
    }

    public void LoadGame()
    {

    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
