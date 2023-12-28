using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    private Vector3 direction;
    private float damage = 5;
    private void OnEnable()
    {
        direction = (GameManager.Instance.player.transform.position - transform.position).normalized; //��ŸŸ�� �׽�Ʈ
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
            collision.gameObject.GetComponent<Character>().Hit(damage);
            Debug.Log("�Ʊ����� ����");
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "EnterDoor")
        {
            gameObject.SetActive(false);
        }
    }




}
