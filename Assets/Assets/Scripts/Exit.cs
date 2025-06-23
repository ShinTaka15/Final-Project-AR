using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void doExitGame()
    {
        Application.Quit();
        # if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        # endif 
        Debug.Log("Game is exiting");
    }
}
