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
        // Timer to count down the time the mole is idle for.
        public float timer = 0;
        // When the mole is hit or missed it changes colour and the score goes up or down.
        public bool hit = false;
        public bool missed = false;

        
        private void Update()
        {
            // If the mole is active, the timer will count down. And if the timer reaches 0 and the player doesn't hit the mole it will miss otherwise it will hit.
            if (isActive)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    if (!hit)
                    {
                        Missed();
                    }
                    else
                    {
                        Hit();
                    }
                    if (timer <= -1)
                    {
                        SetActive();
                        timer = activeTime;
                    }
                    else
                    {
                        SetInActive();
                        timer = activeTime;
                    }
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
            hit = true;
            missed = true;
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
                isActive = true;
                timer = activeTime;
                hit = false;
                missed = true;
            }
            else if (isActive && !missed)
            {
                // if it is hit while active color changes to the hit color
                uiImage.color = hitColour;
                //Score go up when clicked
                Manager.instance.ScoreUp(1);
                isActive = false;
                timer = activeTime;
                hit = true;
                missed = false;
            }

        }
        // these two functions are called when the timer runs out and the mole is missed or hit. It changes the colour and updates the score accordingly.
        public void Missed()
        {
            missed = true;
            uiImage.color = missColour;
            Manager.instance.ScoreDown(1);
        }
        public void Hit()
        {
            hit = true;
            uiImage.color = hitColour;
            Manager.instance.ScoreUp(1);
        }
    }
}