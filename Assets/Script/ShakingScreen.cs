using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShakingScreen : MonoBehaviour
{
    public Animator camAnim;
    public AudioSource killSound;
    private int score = 1;
    private int score2 = 1;
    public Text scoreDisplay;
    public Text scoreDisplay2;
    public Text highScore;
   // public GameOScript GameOScript;

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HIGHSCORE", 0).ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CamShake()
    {
        scoreDisplay.text = score.ToString();
        score+=1;
        scoreDisplay2.text = score2.ToString();
        score2 += 1;
        if (score2 -1 > PlayerPrefs.GetInt("HIGHSCORE", 0))
        {
            PlayerPrefs.SetInt("HIGHSCORE", score2 -1);
            highScore.text = score2.ToString();
        }

        killSound.Play();
        camAnim.SetTrigger("Shake");
       // GameOScript.SetUp(1);


    }
}
