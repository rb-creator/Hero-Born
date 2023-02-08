using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public GameBehaviour GameManager;

    private void Start()
    {
        GameObject obj = GameObject.Find("Game_Manager");
        GameManager = obj.GetComponent<GameBehaviour>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {

            Destroy(this.transform.gameObject);
            Debug.Log("Item collected");
            GameManager.Items += 1;

        }
    }
}
