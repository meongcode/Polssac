using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Character : MonoBehaviour
{
    public float MaxHp { get;  set;}
    public float Hp { get;  set; }

    private void Start()
    {
        MaxHp = 200;
        Hp = 200;
    }

    public void Hit(float value)
    {
        Hp -= value;
        if (Hp <= 0) 
        {
            Death();
        }
    }

    private void Death()
    {
        Debug.Log("Á×À½");
        gameObject.SetActive(false);
    }
}
