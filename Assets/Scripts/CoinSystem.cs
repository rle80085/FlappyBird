using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CoinSystem : MonoBehaviour
{
    public TMP_Text coinText;

    public int Coins = 0;

    public bool TransitioningToFinalBossLevel1000GodLikeHardSkillBigPro = false;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CoinAdder"))
        {
            Coins++;

        }
    }
    private void Update()
    {
        coinText.text ="Points: " + Coins.ToString();

        if (Coins > 10)
        {
            TransitioningToFinalBossLevel1000GodLikeHardSkillBigPro = true;
        }
    }

}
