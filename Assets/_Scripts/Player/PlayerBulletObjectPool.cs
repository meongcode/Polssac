using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBulletObjectPool : MonoBehaviour
{
    private MovementEventController _movementEventController;
    public GameObject bulletObject;
    public GameObject[] gameObjects;
    private int pivot = 0;

    private void Awake()
    {
        _movementEventController = transform.parent.GetChild(0).gameObject.GetComponent<MovementEventController>();
    }
    void Start()
    {
        _movementEventController.AttackEvent += Shot;

        gameObjects = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            GameObject gameObject = Instantiate(bulletObject,transform);
            gameObjects[i] = gameObject; 
            gameObject.SetActive(false);
        }
    }

    private void Shot()
    {
        gameObjects[pivot++].SetActive(true);
        if (pivot == 10) pivot = 0;
    }



}