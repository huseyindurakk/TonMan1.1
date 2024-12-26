using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script when attached to collectibles  make them destroy when player touches them.
//It then calls incrementScore from game manager to add scores.



public class Collection : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.name == "Player")
            {   
                GameManager.incrementScore();
                Destroy(gameObject);
            }
    }
}
