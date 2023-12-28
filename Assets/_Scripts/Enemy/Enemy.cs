using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public bool Hit(float value)
    {
        Hp -= value;
        if (Hp <= 0)
        {
            Death();
            return true;
        }
        return false;
    }

    private void Death()
    {

        gameObject.SetActive(false);
    }
}
