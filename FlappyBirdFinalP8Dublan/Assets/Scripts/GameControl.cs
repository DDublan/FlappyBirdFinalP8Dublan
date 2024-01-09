using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public TextMeshProUGUI scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private int score = 1;

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
        scoreText.text = "Score: " + score.ToString ();
    }
    public void BirdDied()
    {
        gameOverText.SetActive (true);
        gameOver = true;
    }

  }

