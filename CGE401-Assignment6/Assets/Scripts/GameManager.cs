using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    public int score;

    //variable to keep track of what level we're on
    private string CurrentLevelName = string.Empty;

    #region This code makes this class a Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //make sure this game manager persists across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Trying to instantiate a sescond" +
                    "instance of singleton Game Manager");
        }
    }
    #endregion

    //methods to load and unload scenes
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null)
        {
            Debug.LogError("[GameManager] unable to load level" + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] unable to unload level" + levelName);
            return;
        }
    }
}
