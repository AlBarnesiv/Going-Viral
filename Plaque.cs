using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Plaque : MonoBehaviour
{
    // Player player;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    float plaqueSpeed = 2;
    [SerializeField] Rigidbody2D myrigidbody;

    // bool slow = false;


    /* void Awake(){
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
         Debug.Log("Gotten");} */

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // slow = true;
            // Debug.Log("Slown");
            audioSource.Play();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // slow = false;
            audioSource.Stop();
        }
    }

    void Update()
    {
        myrigidbody.velocity = Vector2.left * plaqueSpeed;
    }

    /* if (slow == true){
         player.playerSpeed = 1;}
     else{
         player.playerSpeed = 3;} */
}
