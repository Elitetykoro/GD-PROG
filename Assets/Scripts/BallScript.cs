using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    private int x,y,z;
    private void CreateBall(Color c,Vector3 pos)
    {
        GameObject ball = Instantiate(prefab, pos, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
        StartCoroutine(DestroyBall(ball));
    }
    private IEnumerator DestroyBall(GameObject destroyObject)
    {
        yield return new WaitForSeconds(3);
        DestroyBall(destroyObject);

    }

    private float elapsedTime = 0f;
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Color randColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            CreateBall(randColor, new Vector3(x,y,z));
            elapsedTime = 0f;
        }
    }
}
