using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOScript : MonoBehaviour
{
    public Text S;
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        S.text = "SCORE:"+score.ToString();
    }
}
