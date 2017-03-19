using UnityEngine;
using System.Collections;

public class ShotMove : MonoBehaviour {

    [SerializeField] private GameObject Effect;
    private float lifeTimer = 1.0f;
    private bool collisionFlag = false;
    private float normalTimer = 0;

    void Update() {
        if (collisionFlag)
        {
            lifeTimer -= Time.deltaTime;
            if ( lifeTimer <= 0)
            {
                Destroy(gameObject);
            }
        }
        normalTimer += Time.deltaTime;

        if (normalTimer >= 3)
        {
            Destroy(gameObject);
        }
    }

    public void shotHit() {
        collisionFlag = true;
        if (Effect != null)
        {
            Effect.SetActive(true);
        }
    }
}