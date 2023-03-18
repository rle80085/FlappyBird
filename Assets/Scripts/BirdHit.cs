using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHit : MonoBehaviour
{
    public AudioSource HitSound;

    private void Awake()
    {
        HitSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bird"))
        {
            collision.gameObject.SetActive(false);
            HitSound.Play();
            Time.timeScale = 0;
        }
    }
}
