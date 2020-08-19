using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    int minute;
    float seconds;
    float oldSeconds;

    // Start is called before the first frame update
    void Start()
    {
        minute=0;
        seconds=0f;    
    }

    // Update is called once per frame
    void Update()
    {
        seconds+=Time.deltaTime;
        if(seconds>=60f){
            minute++;
            seconds=seconds-60;
        }
        if((int)seconds != (int)oldSeconds){
            timerText.text = minute.ToString("00")+":"+seconds.ToString("00");
        }
        oldSeconds=seconds;
   }

   public float GetSeconds(){
       return seconds;
   }

   public int GetMinute(){
       return minute;
   }
}
