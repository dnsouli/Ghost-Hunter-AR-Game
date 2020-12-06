using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        var points = PlayerPrefs.GetInt("Score");
        scoreText.text = "Score: " + points;
    }
}
