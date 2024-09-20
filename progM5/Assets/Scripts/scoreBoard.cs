using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreBoard : MonoBehaviour
{
    public float score = 0;
    private TMP_Text scoreField;
    // Start is called before the first frame update
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        Enemy.death += Points;
    }

    // Update is called once per frame
    void Update()
    {
        scoreField.text = "Score:" + score;

    }
    private void Points()
    {
        score += 50;
    }
}
