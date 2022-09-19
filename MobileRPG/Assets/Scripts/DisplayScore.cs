using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public GameObject mainScoreText;
    public static int mainScore;


    private void Start()
    {
        mainScore = 1;
    }

    // Update is called once per frame
    void Update()
    {
        mainScoreText.GetComponent<Text>().text = "Score: " + mainScore;
    }
}
