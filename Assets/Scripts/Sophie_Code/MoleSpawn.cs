using Unity.VisualScripting;
using UnityEngine;

public class MoleSpawn : MonoBehaviour
{
    // Announce Prefab Mole 
    public GameObject[] moles;
      
    // Announce MoleGrid?
    public GameObject moleGrid;
    public int numberOfMoles = 9;
    public GameObject molePrefab;
    public Manager manager;

    // On Game start (bool?) start function.
    private void Start()
    {
        Spawn();
        // spawn 9 moles
        // Randomly activate a mole (turn yellow)
    }

    void Spawn ()
    {
        //Spawn moles acording to an established number 9 for now 
        moles = new GameObject[numberOfMoles];
        //If existing array clear and make new 
        for (int i = 0; i < numberOfMoles; i++)
        {//spawn
            GameObject spawnedMole = Instantiate(molePrefab, moleGrid.transform);
            moles[i] = spawnedMole;
        }
        manager.moles = moles;
    }
 

   

    
}
