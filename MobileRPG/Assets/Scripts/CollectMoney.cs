using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMoney : MonoBehaviour
{
    //public AudioSource collectMainSound;

    void OnTriggerEnter2D(Collider2D collider)
    {
        //collectMainSound.Play();
        DisplayScore.mainScore += 1;
        Destroy(gameObject);
    }
}
