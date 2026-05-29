using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


namespace Sophie
{
    public class Manager : MonoBehaviour
    {
        public static Manager instance;
        //Referencing the mole aray
        public GameObject[] moles;
        // To see the random value within the inspecter
        [SerializeField] int randomIndexValue;
        public GameObject scoreText;

        public float timer;
        // left mouse click yellow mole = hit flashes green before turning back to base 

        // Clicking a mole that isnt yellow = miss flashes red before turning back to base

        public void Start()
        {
            // Plays the Random mole Function when game starts
            RandomMole();
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
            // Selects a random mole to pop up and if the player clicks on the mole then it will flash green and if the player misses the mole it will flash red.
            if (moles[randomIndexValue].GetComponent<Mole>().isActive == false)
            {

                // currently it changes colour at a certain time but it needs to change colour when the player clicks or misses the mole.
                timer += Time.deltaTime;
                if(timer >= 1f)
                {
                    timer = 0;
                    foreach (GameObject mole in moles)
                    {
                        mole.GetComponent<Mole>().SetInActive();
                    }
                    RandomMole();
                }
            }
        }


    }
}