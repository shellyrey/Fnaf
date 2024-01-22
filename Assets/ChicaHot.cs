using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicaHot : MonoBehaviour
{
    public GameObject chica1;
    public GameObject chica2;
    public GameObject chica3;

    public float chicaMove = 0f;
    public int chicaPosition = 0;
    public int chicaAI = 50;

    // Update is called once per frame
    void Update()
    {
        chicaMove += 0.1f;

        if (chicaPosition == 0 && chicaMove >= 100) 
            {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if(roll <= chicaAI)
            {
                chica1.SetActive(true);
                chica2.SetActive(false);
                chica3.SetActive(false);

                chicaPosition = 1;
            }
        }

        if (chicaPosition == 1 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(true);
                chica3.SetActive(false);

                chicaPosition = 2;
            }
        }

        if (chicaPosition == 2 && chicaMove >= 100)
        {
            int roll = Random.Range(1, 101);
            chicaMove = 0f;

            if (roll <= chicaAI)
            {
                chica1.SetActive(false);
                chica2.SetActive(false);
                chica3.SetActive(true);

                chicaPosition = 3;
            }
        }
    }
}
