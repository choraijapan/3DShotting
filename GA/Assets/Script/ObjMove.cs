using UnityEngine;
using System.Collections;

public class ObjMove : MonoBehaviour {

    [SerializeField] private AudioClip sEHit; //追加
    private AudioSource audioSource; //追加

    private bool dead = false;
    private float deadTimer = 0;
    public int life = 150;

    //    void Start() { //追加
    //        audioSource = gameObject.GetComponent<AudioSource>(); //追加
    //        audioSource.clip = sEHit; //追加
    //    } //追加

    private void Start()
    {
        life = 150;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = sEHit;
    }
    void Update() {
        if (GameOver.GameOverFlag)
        {
            return;
        }

        if (dead)
        {
            deadTimer += Time.deltaTime;
            if (deadTimer >= 1.0f)
            {
                Destroy(gameObject);
            }
        }
        Vector3 point = transform.localPosition;
        if (dead)
        {
            point.z += Time.deltaTime * 5.0f;
        }
        else
        {
            point.z -= Time.deltaTime * 5.0f;

            if ( point.x <= -0.5f )
            {
                point.x += Time.deltaTime * 0.5f;

            }
            else if (point.x >= +0.5f)
            {
                point.x -= Time.deltaTime * 0.5f;
            }
        }

        if (point.z <= -9.1f)
        {
            GameOver.GameOverFlag = true;
        }

        if (point.y >= 5.0f)
        {
            point.y = 5.0f;
        }
       // transform.localPosition = point;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play(); //追加
            life--;
            if (life <= 0)
            {
                dead = true;
            }
            Score.ScorePoint++;
            collision.transform.GetComponent<ShotMove>().shotHit();
        }
    }
}