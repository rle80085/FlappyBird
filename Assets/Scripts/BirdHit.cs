using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            SceneManager.LoadScene(0);
        }
    }
}
