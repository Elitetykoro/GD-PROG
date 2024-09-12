using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerSpawner : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Prefab, new Vector3(Random.Range(-10,10), Random.Range(-10, 10), Random.Range(-10, 10)),Quaternion.identity);
        }
    }
}
