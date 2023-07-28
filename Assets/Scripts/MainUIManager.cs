using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    public Text bestScoreText;


    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = PersistenceManager.Instance.playerName + " Best Score : " + PersistenceManager.Instance.bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
