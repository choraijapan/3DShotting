using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public static int ScorePoint = 0;
    [SerializeField] private Text ScoreText;

    void Start() {
        ScorePoint = 0;
        Time.timeScale = 1.0f;
    }

    void Update() {
        ScoreText.text = "ScorePoint:" + ScorePoint;
        Time.timeScale = 1.0f + (float)ScorePoint / 150;
    }
}