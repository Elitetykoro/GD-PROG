using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> enemyList;
    public GameObject prefab;
    private float time;

    // Update is called once per frame
    private void Start()
    {
        enemyList.Add(prefab);
    }
    void Update()
    {
        time += Time.deltaTime;

        if (prefab.CompareTag("Untagged"))
        {
            enemyList.Add (prefab);
        }
        
        if (time > 3)
        {
            Instantiate(prefab);
            time = 0;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Destroy(prefab);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                Instantiate(prefab);
            }
        }
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].gameObject.tag = "isTagged";
        }
    }
}
