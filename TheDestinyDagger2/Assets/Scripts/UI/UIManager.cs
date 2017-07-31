using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {

	//Set variable for the score value
    public int score;
	//Set variable for the score multiplier
    public int multiplier;
	//Set variable for the text of the score
    public Text scoreText;
	//Set variable for whether the score is running or not.
    private bool scoreRun = true;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		//Set statement for if the space key is pressed
        if (Input.GetKey(KeyCode.Space) == true)
        {
            scoreRun = false;
        }
		
		//Set statement for if scoreRun is true
        if (scoreRun == true)
        {
			//Add to the score at a constant rate
            score += multiplier;

			//Set the text variable to display the score
            scoreText.text = score.ToString();
        }
	}
}
