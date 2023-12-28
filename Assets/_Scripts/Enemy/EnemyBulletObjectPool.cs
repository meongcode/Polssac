using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletObjectPool : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject[] gameObjects;
    private int pivot = 0;

    private void Awake()
    {

    }
    void Start()
    {
        gameObjects = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            GameObject gameObject = Instantiate(bulletObject, transform);
            gameObjects[i] = gameObject;
            gameObject.SetActive(false);
        }
        StartCoroutine("EnemyBullet");
    }
    IEnumerator EnemyBullet()
    {
        yield return new WaitForSeconds(1f);
        gameObjects[pivot++].SetActive(true);
        if (pivot == 5) pivot = 0;
        StartCoroutine("EnemyBullet");
    }
}
