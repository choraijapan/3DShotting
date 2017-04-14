using UnityEngine;
using System.Collections;

public class ShotControl : MonoBehaviour {

    [SerializeField] private GameObject shot;
//    [SerializeField] private AudioClip sEShot; //追加
//    private AudioSource audioSource; //追加

    private float shotWait = 0;

//    void Start() { //追加
//        audioSource = gameObject.GetComponent<AudioSource>(); //追加
//        audioSource.clip = sEShot; //追加
//    } //追加

    void Update() {
        if (shotWait > 0)
        {
            shotWait -= Time.deltaTime;
            return;
        }

        if (GameOver.GameOverFlag)
        {
            return;
        }

        if (Input.GetMouseButton(0))
        {
            shotWait = 0.1f;
//            audioSource.Play(); //追加

            Vector3 point = transform.localPosition;
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Shot at Screen Center
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));


            RaycastHit hit;
            Vector3 hitPoint;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.gameObject == null)
                    return;

                hitPoint = hit.point;
            }
            else
            {
                return;
            }

            point.x += Random.Range(0.5f, -0.5f);
            point.y += Random.Range(0.5f, -0.5f);
            point.z += Random.Range(1.5f, 0.5f);
            GameObject obj = (GameObject)Instantiate(shot);
            obj.transform.localPosition = point;

            Vector3 nVec = Vector3.Normalize(hitPoint - obj.transform.position);

            obj.transform.LookAt(hitPoint);

            obj.transform.GetComponent<Rigidbody>().AddForce(nVec * 3500);
        }
    }
}