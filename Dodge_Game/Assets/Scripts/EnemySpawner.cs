using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy enemy;
    public GameObject enemyGroup;
    private bool isPlaying = true;

    public void OffSpawner()
    {
        isPlaying = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            int SpawnPer = Random.Range(0, 1001);
            if (SpawnPer < 333)
            {
                Enemy e = Instantiate(enemy);
                float posY = Random.Range(-7.4f, 7.4f);
                int isLeftInstatiate = Random.Range(0, 2);

                if (isLeftInstatiate == 0)
                {
                    e.transform.position = new Vector3(-8.7f, posY, -1);
                    e.transform.rotation = new Quaternion(0, 0, 0, 0);
                    e.SetDirecterVector(1);
                }
                else
                {
                    e.transform.position = new Vector3(8.7f, posY, -1);
                    e.transform.rotation = new Quaternion(0, 0, 180, 0);
                    e.SetDirecterVector(-1);
                }
                e.transform.parent = enemyGroup.transform;
            }
        } 
    }
}
