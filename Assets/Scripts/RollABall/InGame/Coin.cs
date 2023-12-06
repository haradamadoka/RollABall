using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bigBonusTime = 1f;

    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scoreValue = 10;
    private int bonusScoreValue = 20;

    private int bigBonusScoreValue = 100;

    private enum bonusChance
    {
        Invalide=-1,
        BigBonus,
        SmallBonus,
        NoBonus
    }

    private bonusChance bonusChances;

    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // ここまではボーナスタイムの2秒待つ
        yield return new WaitForSeconds(bonusTime);
        
        // 消える時間は5秒なので、ボーナスタイムを2秒消費した3秒待つ
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (isBonus)
            {
                ScoreManager.ScoreCount += bonusScoreValue;
            }
            else
            {
                ScoreManager.ScoreCount += scoreValue;
            }

            Destroy(gameObject);
        }
    }
}
