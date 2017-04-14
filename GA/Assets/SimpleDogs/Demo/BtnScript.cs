using UnityEngine;
using System.Collections;


public class BtnScript : MonoBehaviour {
    GameObject go1 = null;
    Animator ator1 = null;

    void Start()
    {
        go1 = DogController.getGameObject();
        ator1 = go1.GetComponent<Animator>();
        
    }

    public void OnClickEat()
    {
        DogController.Eat();
    }

    public void OnClickSit()
    {
        DogController.Sit();
    }

    public void OnClickWalk()
    {
        DogController.Walk();
    }
}
