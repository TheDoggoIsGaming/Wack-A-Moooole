using UnityEngine;
using UnityEngine.UI;

namespace Sophie
{
    public class CountdownTimer : MonoBehaviour
    {
        public static CountdownTimer countdownTimerInstance;
        //the number that you are counting down form, the duration of the timer
        public float countDownFrom;
        // The number that the timer is currently at 
        public float currentNumber;
        //The text that this will effect
        public Text countDown;
       
        //The text element countDown is held within the image CountDownHolder 
        public Color difficulty1 = Color.black;
        public Color difficulty2 = Color.orange;
        public Color difficulty3 = Color.red;


        private void Awake()
        {
            if (countdownTimerInstance == null)
            {
                countdownTimerInstance = this;
            }
            else if (countdownTimerInstance != null && countdownTimerInstance != this)
            {
                Destroy(this);
            }
        }
        //On enable instead of on start so that in theory it only begins when the HUB is on screen 
        void OnEnable()
        {
            //The current Number equals that of the total number(the highest number)
            currentNumber = countDownFrom;
        }
        void Update()
        {
            //Calling the function to be used on an update 
            CountingDown();
            TimerColor();
            
        }

        public void TimerColor()
        {
            if (currentNumber <= 60 && currentNumber > 40)
            {
                countDown.color = difficulty1;
            }
            else if (currentNumber <= 40 && currentNumber > 20)
            {
                countDown.color = difficulty2;
            }
            else
            {
                countDown.color = difficulty3;
            }
        }

        // Function to have a derease in time 
        public void CountingDown()
        {
            // the current number is not equal to the time.deltaTime 
            currentNumber -= Time.deltaTime;
            //if the current number is equal or less than 0 Do;
            if(currentNumber <= 0 )
            {
                //Current number equa ls zero, so if the current number would be less then 0 it stays at zero.
                currentNumber = 0;
                //End Game(not possible as of now). To be added with the addition of an end game screen. 

            }
            // minutes is equal to currentNumber divided by 60
            // Second is equal to currentNumber is the remainder of 60
            //Converts the value to minutes and seconds 
            int minutes = Mathf.FloorToInt(currentNumber / 60);
            int seconds = Mathf.FloorToInt(currentNumber % 60);
            //Updates the text element to display the current time in minutes and seconds. 
            countDown.text = string.Format("{0:00}:{1:00}",minutes,seconds);
        }
        
    }

    
}
  


