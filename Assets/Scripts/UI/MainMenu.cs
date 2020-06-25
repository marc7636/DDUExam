using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public byte currentSaveSlot { 
        get
		{

		} 
    }
    public int gameSceneIndex;
    public GameObject NewGameObject;
    public GameObject LoadGameObject;

    public void Continue()
	{
        
	}

    public void NewGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    public void LoadGame()
	{

	}

    public void Exit()
    {
        Application.Quit();
    }
}
