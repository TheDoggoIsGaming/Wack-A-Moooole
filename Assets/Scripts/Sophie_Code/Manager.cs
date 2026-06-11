using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


namespace Sophie
{
    public class Manager : MonoBehaviour
    {
        public CountdownTimer countDownTimerScript;
        public static Manager instance;
        public Mole Mole;
        //Referencing the mole aray
        public GameObject[] moles;
        // To see the random value within the inspecter
        [SerializeField] int randomIndexValue;
        public Text scoreText;
        public int score;
        public float timer;
        public Difficulty currentDifficulty;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if(instance != null && instance != this)
            {
                Destroy(gameObject);
            }
        }

        public void Start()
        {
            currentDifficulty = DifficultyLevel1();
            // Plays the Random mole Function when game starts
            RandomMole();
            // Sets the score to 0 at the start of the game and updates the score display
            UpdateScoreDisplay();
        }
       public void ScoreUp(int value)
        {
            // When the player hits a mole the score goes up and updates the score display
            score+= value;
            UpdateScoreDisplay();
        }
        public void ScoreDown(int value)
        {
            // When the player misses a mole the score goes down and updates the score display
            score-= value;
            UpdateScoreDisplay();
        }
        void UpdateScoreDisplay()
        {
            // Updates the score display by converting the score to a string and displaying it in the UI text element
            scoreText.text = score.ToString();
        }

        // Selects a random mole from the mole array by selecting a value from the index. 
        // Changes the statis of the selected value into active.
        void RandomMole()
        {
            randomIndexValue = Random.Range(0, moles.Length);
            moles[randomIndexValue].GetComponent<Mole>().ToggleIsActive();
        }

        private void Update()
        {
            int tempCount = currentDifficulty.count;
            // Selects a random mole to pop up and if the player clicks on the mole then it will flash green and if the player misses the mole it will flash red.
            if (moles[randomIndexValue].GetComponent<Mole>().isActive == false)
            {
                // at a certain time it spawns in a mole.
                timer += Time.deltaTime;
                if (timer >= 3f)
                {
                    timer = 0f;
                    foreach (GameObject mole in moles)
                    {
                        mole.GetComponent<Mole>().SetInActive();
                    }
                    RandomMole();
                }
                // If the mole is not active it will select a new random mole until it finds one that is active.
                while (tempCount > 0)
                {
                    RandomMole();
                    tempCount--;
                }
            }
        }

        public Difficulty DifficultyLevel1()
        {
            Difficulty difficulty = new Difficulty();
            //The colour for difficulty 1 is black 
            difficulty.colour = Color.black;
            //The count of moles for difficulty 1 is 1
            difficulty.count = 1;
            //The speed of difficulty 1 is 2
            difficulty.speed = 2f;
            return difficulty;
        }

        public Difficulty DifficultyLevel2()
        {
            Difficulty difficulty = new Difficulty();
            //The colour for difficulty 2 is orange 
            difficulty.colour = Color.orange;
            //The count of moles for difficulty 2 is 1
            difficulty.count = 1;
            //The speed of difficulty 2 is 1.25
            difficulty.speed = 1.25f;
            return difficulty;
        }
        public Difficulty DifficultyLevel3()
        {
            Difficulty difficulty = new Difficulty();
            //The colour for difficulty 3 is Red
            difficulty.colour = Color.red;
            //The count of moles for difficulty 3 is 2
            difficulty.count = 2;
            //The speed for difficulty 3 is 0.75
            difficulty.speed = 0.75f;
            return difficulty;
        }
        
    }
}
[System.Serializable]
public struct Difficulty
{
    public Color colour;
    public int count;
    public float speed;
}