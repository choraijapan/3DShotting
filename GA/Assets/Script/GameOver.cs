using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public static bool GameOverFlag = false;
    [SerializeField] private GameObject text;

    void Start() {
        GameOverFlag = false;
    }

    void OnGUI() {
        if (GameOverFlag)
        {
            text.gameObject.SetActive(true);
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2, 150, 90), "Retry"))
            {
                GameOverFlag = false;
                SceneManager.LoadScene("Main");
            }
        }
        else
        {
            text.gameObject.SetActive(false);
        }
    }
}