using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedBloodCells : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite newSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            audioSource.PlayOneShot(audioClip);
            spriteRenderer.sprite = newSprite;
        }
    }
}
