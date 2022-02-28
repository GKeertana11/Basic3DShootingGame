using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreManager score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.tag == "MyEnemy")
        {
            
            Destroy(Enemy.gameObject);
            score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            score.ScoreCalculator(10);

        }

    }
}
