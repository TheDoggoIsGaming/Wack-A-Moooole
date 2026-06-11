using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Sophie;


namespace Lachlan
{
    public class UIHandler : MonoBehaviour
    {

        public GameObject mainMenu, uiHUD, endScreen;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        #region Singleton
        public static UIHandler instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        #endregion

        //This code allows for the exit button in the main menu to let the user exit to desktop.
        public void ExitToDesktop()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
        public void OpenMainMenu()
        {
            mainMenu.SetActive(true);
            uiHUD.SetActive(false);
            endScreen.SetActive(false);
        }
        public void OpenUIHUD()
        {
            mainMenu.SetActive(false);
            uiHUD.SetActive(true);
            endScreen.SetActive(false);
        }
        public void OpenEndScreen()
        {
            mainMenu.SetActive(false);
            uiHUD.SetActive(false);
            endScreen.SetActive(true);
        }
    }
}