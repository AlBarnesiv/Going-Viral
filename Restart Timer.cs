using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class RestartTimer : MonoBehaviour
{

    // Adds a Timer for furture Ad dev 

    /* public int timer;
    public Text countDown;
    public Text restart;

    void Awake(){
        timer = 5;
    } */

    public void Update()
    {
        // Restarts the game
        Play();

        // Adds a timer for future Ad dev

        /* countDown.text=timer.ToString();
        
        if(timer==1){
            countDown.text = 1.ToString();
            Thread.Sleep(1000);
            DownTick();
        }
        else{
            if(timer==0){
                countDown.text = " ".ToString();
                restart.text = "Restart".ToString();
                Play();
            }
            else{
                Thread.Sleep(1000);
                DownTick();
            }
        } */

    }

    // More Timer Code

    /* void DownTick(){
        timer = timer-1;
    } */

    // Restarts the game
    void Play()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}
