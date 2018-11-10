using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject obj;
    public float spawnTime = 0.1f;
    public float colorTime = 1;
    public Color ballColor;
    public float randColor, randColorTime, randSpawnTime;

    void Start()
    {
        StartCoroutine(Spawn(spawnTime));
        StartCoroutine(Color(colorTime));
    }

    private IEnumerator Spawn(float time)
    {
        yield return new WaitForSeconds(time);
        spawnObject();

        randSpawnTime = Random.Range(0, 100);
        time = spawnTime;// + (randSpawnTime / 100);
        Debug.Log(time);
        StartCoroutine(Spawn(time));
    }

    private IEnumerator Color(float time)
    {
        yield return new WaitForSeconds(time);

        randColor = Random.Range(0, 3);

        if (randColor == 0)
            ballColor = new Vector4(1, 0, 0, 1);
        else if (randColor == 1)
            ballColor = new Vector4(0, 0, 1, 1);
        else if (randColor == 2)
            ballColor = new Vector4(0, 1, 0, 1);

        randColorTime = Random.Range(0, 100);
        StartCoroutine(Color(time + (randColorTime / 100)));
    }

    void spawnObject()
    {
        float x = Random.Range(-2.5f, 2.5f);
        GameObject ball = Instantiate(obj, new Vector3(x, 4.5f, 0f), Quaternion.identity);
        ball.GetComponent<SpriteRenderer>().color = ballColor;
    }
}
