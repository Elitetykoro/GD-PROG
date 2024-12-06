using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Instantiate(Prefab,new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x+Random.Range(-50,50),transform.position.y-90, Camera.main.ScreenToWorldPoint(Input.mousePosition).z + Random.Range(-50, 50)), Quaternion.identity);
        }
    }
}
