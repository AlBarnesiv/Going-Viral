using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{

    Player player;
    [SerializeField] GameObject object1;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    void Awake()
    {
        player = object1.GetComponent<Player>();
    }

    // Player hits wall
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.playerSpeed = player.playerSpeed - 1; // speed reduced
            audioSource.PlayOneShot(audioClip); // sound effect played
        }
    }

    // Player moves away from wall
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.playerSpeed = player.playerSpeed + 1; // speed normalized
        }
    }

}
