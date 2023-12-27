using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBulletObjectPool : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject[] gameObjects;
    private int pivot = 0;
    void Start()
    {
        gameObjects = new GameObject[50];
        for (int i = 0; i < 50; i++)
        {
            GameObject gameObject = Instantiate(bulletObject);
            gameObjects[i] = gameObject; 
            gameObject.SetActive(false);
        }
        StartCoroutine("EnableBullet");
    }
    IEnumerator EnableBullet()
    {
        yield return new WaitForSeconds(0.5f);
        gameObjects[pivot++].SetActive(true);
        if (pivot == 50) pivot = 0;
        StartCoroutine("EnableBullet");
    }
    
}