using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalCount : MonoBehaviour
{
    public GameObject goalZone;
    TextMeshProUGUI scoreText;
    Goal goalScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        goalScript = goalZone.GetComponent<Goal>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + goalScript.goals;
    }
}
