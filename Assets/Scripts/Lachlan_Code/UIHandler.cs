using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Lachlan
{
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
        public void UpdateScore()
        {
            score++;
            scoreText.text = score.ToString();
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

        #region Variables
        public GameState currentState = GameState.PreGame;
        public float globalSpeed = 1.0f;
        public GameObject[] menuPanels = new GameObject[3];

        public int score = 0;
        public Text scoreText;
        #endregion

        void SetMenuPanel()
        {
            for (int i = 0; i < menuPanels.Length; i++)
            {
                menuPanels[i].SetActive(false);
            }
            menuPanels[(int)currentState].SetActive(true);
        }
        public void SetState(GameState newState)
        {
            currentState = newState;

            switch (currentState)
            {
                case GameState.PreGame:
                    score = 0;
                    globalSpeed = 0;
                    break;
                case GameState.Game:
                    globalSpeed = 1.0f;
                    break;
                case GameState.PostGame:
                    globalSpeed = 0;
                    break;
            }
            SetMenuPanel();
        }
        public void RestartGame()
        {
            SetState(GameState.PreGame);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        private void OnAwake()
        {
            SetState(GameState.PreGame);
        }
        public void ExitToDesktop()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }
    public enum GameState
    {
        PreGame,
        Game,
        PostGame,
    }
}