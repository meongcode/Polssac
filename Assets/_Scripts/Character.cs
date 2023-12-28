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

    
}
