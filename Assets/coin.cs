using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
   public GameManager gameManager;

    private void Start()
    {
        GameObject managerobject = GameObject.Find("gamemanager");
        gameManager= managerobject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();
            Destroy(this.gameObject);
        }
    }
}
