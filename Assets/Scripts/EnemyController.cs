using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Text enemyText;
    public GameObject enemy;
    public GameObject killer;
    float seconds;
    int noe;
    // Start is called before the first frame update
    void Start()
    {
        seconds=0;
        noe=1;
    }

    void Enemy(){
        Instantiate(enemy);
    }

    void Killer(){
        Instantiate(killer);
    }

    // Update is called once per frame
    void Update()
    {
        seconds+=Time.deltaTime;
        if(seconds>15){
            seconds=0f;
            noe++;
            if(noe<5){
                Enemy();
            }
            else if(noe>=5){
                Killer();
            }
        }
        enemyText.text="Enemy:"+noe.ToString();
    }
}
