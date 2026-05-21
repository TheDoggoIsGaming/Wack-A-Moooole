
using UnityEngine;


namespace Sophie
{
    public class Manager : MonoBehaviour
    {
        public static Manager instance;
        //Referencing the mole aray
        public GameObject[] moles;
        // To see the random value within the inspecter
        [SerializeField] int randomIndexValue;
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


    }
}