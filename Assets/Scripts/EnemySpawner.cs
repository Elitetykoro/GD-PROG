using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> enemyList;
    public GameObject enemy;
    float time = 0;
    // Update is called once per frame
    private void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) clearFunc();
        if (Input.GetKeyDown(KeyCode.W)) enemySpawnFunc();
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("enemy").Length; i++)
        {
            enemyList.Add(GameObject.FindGameObjectsWithTag("enemy")[i]);
            GameObject.FindGameObjectsWithTag("enemy")[i].gameObject.tag = "isTagged";
        }
        time += Time.deltaTime;
        if (time > 3)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            time = 0;
        }
    }
    void enemySpawnFunc()
    {
        for (int i = 0;i < 100; i++)
        {
            Instantiate(enemy,transform.position,Quaternion.identity);
        }
    }
    void clearFunc()
    {
        for(int i = 0;i < enemyList.Count; i++)
        {
            Destroy(enemyList[i]);
        }
        enemyList.Clear();
    }
}
