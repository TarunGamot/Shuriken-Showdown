using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringafterDead : MonoBehaviour
{
    public Text score;
    public void SU(int point)
    {
        score.text = point.ToString();
    }
   
}
