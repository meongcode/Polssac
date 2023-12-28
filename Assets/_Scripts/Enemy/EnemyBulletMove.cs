using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    private Vector3 direction;
    private float damage = 5;
    private void OnEnable()
    {
        direction = (GameObject.FindWithTag("Player").transform.position - transform.parent.position).normalized;
        transform.position = transform.parent.position;
    }


    private void FixedUpdate()
    {
        transform.position += direction * 5f * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision) //collision�� Tag ���ǿ� �����Ѵٸ� BOOM!!
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().Hit(damage);
            Debug.Log("�Ʊ����� ����");
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "EnterDoor")
        {
            gameObject.SetActive(false);
        }
    }
}
