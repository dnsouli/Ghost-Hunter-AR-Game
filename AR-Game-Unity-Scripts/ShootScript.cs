﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public Text ScoreText;
    public int points;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.Save();
    }

    public void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "enemy1(Clone)"
                || hit.transform.name == "enemy2(Clone)"
                || hit.transform.name == "enemy3(Clone)"
                || hit.transform.name == "ms02_05_Ghost_1(Clone)"
                || hit.transform.name == "ms02_05_Ghost_2(Clone)"
                || hit.transform.name == "ms02_05_Ghost_3(Clone)"
                || hit.transform.name == "ms02_05_Ghost_4(Clone)"
                || hit.transform.name == "ms02_05_Ghost_5(Clone)"
                || hit.transform.name == "ms02_05_Ghost_6(Clone)"
            )
            {
                Destroy(hit.transform.gameObject);

                points += 5;
                PlayerPrefs.SetInt("Score", points);
                PlayerPrefs.Save();

                ScoreText.text = "Score: " + points;

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }

    }

}
