using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
