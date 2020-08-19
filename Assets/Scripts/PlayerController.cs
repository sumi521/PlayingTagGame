using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public TimerController TimerController;
    public GameObject callGameOver; 
    public float MoveSpeed;
    public float RotateSpeed;
    int hit;
    int rMinute;
    float rSeconds;
    // Start is called before the first frame update
    void Start()
    {
        hit=1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(hit==1){
            if(Input.GetKey(KeyCode.LeftArrow)){
                transform.Rotate(0,-5*Time.deltaTime*RotateSpeed,0);
            }

            if(Input.GetKey(KeyCode.RightArrow)){
                transform.Rotate(0,5*Time.deltaTime*RotateSpeed,0);
            }

            if(Input.GetKey(KeyCode.UpArrow)){
                transform.Translate(0f,0f,MoveSpeed*Time.deltaTime);
            }
            if(Input.GetKey(KeyCode.DownArrow)){
                transform.Translate(0f,0f,-1f*MoveSpeed*Time.deltaTime);
            }
        }
        
    }

    void OnCollisionEnter(Collision collision){
        if(hit==1){
            if(collision.gameObject.tag=="Enemy"){
                hit+=1;
                Instantiate(callGameOver);
                rMinute=TimerController.GetMinute();
                rSeconds=TimerController.GetSeconds();
                GameObject result = Instantiate(callGameOver);
                result.transform.Find("Result").GetComponent<Text>().text="Time  "+rMinute.ToString("00")+":"+rSeconds.ToString("00");
                Destroy(GameObject.Find("TimerText"));
            }
        }
    }
}
