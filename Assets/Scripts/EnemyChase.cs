using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



//Enemy Ai is given a navigation map and target to reach them.
public class EnemyChase : MonoBehaviour
{   
    
    public GameObject target;
    public UnityEngine.AI.NavMeshAgent enemyagent;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyagent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
       enemyagent.destination = target.transform.position;
    }

    public void OnCollisionEnter(Collision other)
    {   
        if (other.gameObject.name == "Player")
            {   
                SceneManager.LoadScene("RestartMenu");
            }
    }
}
