using UnityEngine;
using UnityEngine.UI;

namespace Sophie
{
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
        public bool isActive = false;
        //When the mole is idle for a certain time it changes location.
        public int activeTime = 3;
        public float timer = 0;
        public bool hit = true;
        public bool missed = false;

        // after a certain time the mole will appear somewhere else.
        private void Update()
        {
            //
            if(isActive)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    if (!hit)
                    {
                        Missed();
                    } 
                }
                if (timer <= -1)
                {
                    SetActive();
                    timer = activeTime;
                }
            }
        }
        public void ToggleIsActive()
        {
            //There are two states of being that these moles can be. 
            isActive = !isActive;
            IsActive();
        }

        public void SetActive()
        {
            // When this function is called, set active 
            isActive = true;
            IsActive();
        }
        public void SetInActive()
        {
            // When this function is called, set inactive 
            isActive = false;
            hit = false;
            missed = false;
            IsActive();
        }

        bool IsActive()
        {
            // when the mole is active change the colour to the active colour
            if (isActive)
            {
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
        public void IsHit()
        {
            if (!isActive)
            {
                //If it is hit while inactive colour changes to the miss color
                uiImage.color = missColour;
                Manager.instance.ScoreDown(1);
               
            }
            else if(isActive && !missed)
            {
                // if it is hit while active color changes to the hit color
                uiImage.color = hitColour;
                //Score go up when clicked
                Manager.instance.ScoreUp(1);
                isActive = false;
                timer = activeTime;
                hit = true;
            }

        }
        public void Missed()
        {
            missed = true;
            uiImage.color = missColour;
            Manager.instance.ScoreDown(1);
        }
    }

}