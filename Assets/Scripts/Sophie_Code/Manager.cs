
using UnityEngine;


public class Manager : MonoBehaviour
{
    public static Manager instance;
    public GameObject[] moles;
    [SerializeField] int randomIndexValue;
    // left mouse click yellow mole = hit flashes green before turning back to base 

    // Clicking a mole that isnt yellow = miss flashes red before turning back to base

    public void Start()
    {
        RandomMole();
    }

    void RandomMole()
    {
        randomIndexValue = Random.Range(0, moles.Length);
        moles[randomIndexValue].GetComponent<Mole>().ToggleIsActive();
    }


}