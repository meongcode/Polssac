using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
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
        gameObject.SetActive(false);
        GameManager.Instance.endPopUp.SetActive(true);
    }
}
