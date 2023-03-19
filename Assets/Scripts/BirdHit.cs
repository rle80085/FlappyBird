using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHit : MonoBehaviour
{
    public AudioSource hitSound;

    private void Awake()
    {
        hitSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bird"))
        {
            collision.gameObject.SetActive(false);
            hitSound.Play();

            Time.timeScale = 0;
            AudioListener.pause = true;
        }
    }
}
