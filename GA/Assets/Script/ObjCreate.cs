using UnityEngine;
using System.Collections;

public class ObjCreate : MonoBehaviour {

    [SerializeField] private GameObject obj;
    [SerializeField] private float maxTimer = 0;
    private float timer = 0;

    void Update() {
        if (GameOver.GameOverFlag)
        {
            return;
        }
        timer += Time.deltaTime;

        if (timer >= maxTimer)
        {
            timer = 0;

            int loop = 1 + Random.Range(0, 3);
            for (int i = 0; i < loop; i++) {
                GameObject objData = (GameObject)Instantiate(obj);
                objData.transform.localPosition = new Vector3(Random.Range(-5.0f, 5.0f),
                        Random.Range(-20.0f, 25.0f), Random.Range(13.0f, 14.0f));
            }
        }
    }
}