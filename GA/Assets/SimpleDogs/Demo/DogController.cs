using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DogController : MonoBehaviour {
    public static Animator ator1 = null;
    public static GameObject go = null;
    // Use this for initialization
    void Start () {
        ator1 = this.gameObject.GetComponent<Animator>();
        go = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
    }

    public static GameObject getGameObject()
    {
        return go;
    }

    public static void Eat()
    {
        ator1.Play("Eat");
    }

    public static void Bark()
    {
        ator1.Play("Bark");
    }

    public static void Walk()
    {
        ator1.Play("Walk");
    }

    public static void Sit()
    {
        ator1.Play("Sit");
    }

    public static void reset()
    {
        ator1.ResetTrigger("Eat_b");
        ator1.ResetTrigger("Bark_b");
        ator1.ResetTrigger("Walk_b");
        ator1.ResetTrigger("Sit_b");
    }

}
