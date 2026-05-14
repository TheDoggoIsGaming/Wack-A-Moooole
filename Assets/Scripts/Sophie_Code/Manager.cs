using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] moles;
    public int randomMole;
    // left mouse click yellow mole = hit flashes green before turning back to base 

    // Clicking a mole that isnt yellow = miss flashes red before turning back to base
    public Mole ToggleIsActive;

    

    void RandomMole()
    {
        
       
       int randomMole = Random.Range(0, moles.Length);
       


    }

}