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
    GameObject[] children;
    CanvasGroup canvasGroup;

    private void Awake()
    {
        backgroundImage = GetComponent<Image>();
        children = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            children[i] = transform.GetChild(i).gameObject;
        }
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
        if (pausingIsAllowed)
        {
            backgroundImage.enabled = state;
            foreach (GameObject child in children)
            {
                child.SetActive(state);
            }
            eventSystem.SetActive(state);

            if (state)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
            canvasGroup.interactable = state;
            canvasGroup.blocksRaycasts = state;

            GameIsPaused = state;
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
