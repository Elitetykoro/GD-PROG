using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    private int x,y,z;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            //Color color = RandomColor();
            //Vector3 randPos = RandomPosition(-10f, 10f);
            //CreateBall(color, randPos);
        }
    }
    private void CreateBall(Color c,Vector3 pos)
    {
        GameObject ball = Instantiate(prefab, pos, Quaternion.identity);
        Material material = ball.GetComponent<Material>();
        material.SetColor("_Color", c);
        StartCoroutine(DestroyBall(ball));
    }
    private IEnumerator DestroyBall(GameObject destroyObject)
    {
        yield return new WaitForSeconds(1);
        DestroyBall(destroyObject);

    }

    private float elapsedTime = 0f;
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            //Color color = RandomColor();
            //Vector3 randPos = RandomPosition(-10f, 10f);
            //GameObject ball = CreateBall(color, randPos);
            //DestroyBall(ball);
            elapsedTime = 0f;
        }
    }
}
