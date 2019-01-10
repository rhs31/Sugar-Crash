using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public Transform player;
    public Text scoreText;
    public int timeElapsed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed = (int)Time.timeSinceLevelLoad;
        scoreText.text = timeElapsed.ToString();
	}
}
