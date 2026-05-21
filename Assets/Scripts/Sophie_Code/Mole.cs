using UnityEngine;
using UnityEngine.UI;

public class Mole : MonoBehaviour
{
    // Telling the code to access the sprite renderer 
    public Image uiImage;
    //When a mole is active it is yellow
    public Color activeColour = Color.yellow;
    // When a mole is pressed when not active it is red
    public Color missColour = Color.red;
    // When a mole is pressed when active it is green
    public Color hitColour = Color.green;
    // When a mole is not active it is white
    public Color inActiveColour = Color.white;
    //Sets the base of the moles as not active 
    private bool isActive = false;

    public void ToggleIsActive()
    {
        //There are two states of being that these moles can be. 
        isActive = !isActive;
        IsActive();
    }  

    public void SetActive()
    {
        isActive = true;
        IsActive();
    }
    public void SetInActive()
    {
        isActive = false;
        IsActive();
    }

    bool IsActive()
    {
        // when the mole is active change the colour to the active colour
        if (isActive)
        {
            //
            uiImage.color = activeColour;
            return true;
        }
        // If it is not active turn it into the inactive colour
        else
        {
            uiImage.color = inActiveColour;
            return false;
        }
    }
    public bool IsHit()
    {
        if (!isActive)
        {
            uiImage.color = missColour;
            return true;
        }
        else
        {
            uiImage.color = hitColour;
            return false;
        }

    }
}
