using Unity.VisualScripting;
using UnityEngine;

namespace Sophie
{
    public class MoleSpawn : MonoBehaviour
    {
        // Announce Prefab Mole 
        public GameObject[] moles;

        // Announce MoleGrid?
        public GameObject moleGrid;
        //Announce the public int to know how many moles to spawn 
        public int numberOfMoles = 9;
        //Referencing the mole prefab
        public GameObject molePrefab;
        //Reference to the manager sript 
        public Manager manager;




        // On Game start (bool?) start function.
        private void Awake()
        {
            //Do as early as they can when game begins
            Spawn();

        }

        void Spawn()
        {
            //Spawn moles acording to an established number 9 for now 
            moles = new GameObject[numberOfMoles];
            //If existing array clear and make new 
            for (int i = 0; i < numberOfMoles; i++)
            {
                // This is to repeatedly spawn the mole prefab into the grid 
                GameObject spawnedMole = Instantiate(molePrefab, moleGrid.transform);
                // Every mole is a spawned mole. 
                moles[i] = spawnedMole;
            }
            manager.moles = moles;
        }
    }
}


