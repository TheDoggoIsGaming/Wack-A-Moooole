using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void HighscoreCounter()
    {

    }
    public void ScoreCounter()
    {
        
    }


    public void ExitToDesktop()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
