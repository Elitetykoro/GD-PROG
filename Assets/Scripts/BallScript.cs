using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject prefab;
    private int x,y,z;
    float r,g,b;
    Color randColor;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            CreateBall(color, randPos);
        }
    }
    private Color RandomColor()
    {
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        return new Color(r, g, b);
    }
    private Vector3 RandomPosition(float x,float y)
    {
        Vector3 RandomPosition = new Vector3(Random.Range(x, y), Random.Range(x, y), Random.Range(x, y));
        return RandomPosition;
    }
    private GameObject CreateBall(Color c,Vector3 pos)
    {
        GameObject ball = Instantiate(prefab, pos, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        if (material.shader.name == "Universal Render Pipeline/Lit") material.SetColor("_BaseColor", c);
        else Debug.LogWarning("Pleeg Zelfmoord");
        StartCoroutine(DestroyBall(ball));
        return ball;
    }
    private IEnumerator DestroyBall(GameObject destroyObject)
    {
        yield return new WaitForSeconds(3);
        DestroyBall(destroyObject);

    }

    private float elapsedTime = 0f;
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Vector3 randPos = RandomPosition(-5,5);
            Color randColor = RandomColor();
            GameObject ball = CreateBall(randColor, randPos);
            DestroyBall(ball);
            elapsedTime = 0f;
        }
    }
}
