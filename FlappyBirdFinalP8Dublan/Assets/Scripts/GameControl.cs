using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null) { 
            instance = this;
        } else if (instance != this)
        {
            Destroy (gameObject);
        }
}

    void Update () {

}
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "0" +
            "0" + score.ToString ();
    }
    public void BirdDied()
    {
        gameOverText.SetActive (true);
        gameOver = true;
    }

  }

