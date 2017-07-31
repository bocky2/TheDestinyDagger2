using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public int score;
    public int multiplier;
    public Text scoreText;
    private bool scoreRun = true;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            scoreRun = false;
        }

        if (scoreRun == true)
        {
            score += 1;

            scoreText.text = score.ToString();
        }
	}
}
