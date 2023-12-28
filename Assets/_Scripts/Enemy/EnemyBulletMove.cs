using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    private Vector3 direction;
    private float damage = 5;
    private void OnEnable()
    {
        direction = (GameManager.Instance.player.transform.position - transform.position).normalized; //델타타임 테스트
        transform.position = transform.parent.position;
    }

    private void FixedUpdate()
    {

        transform.position += direction * 5f * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision) //collision이 Tag 조건에 만족한다면 BOOM!!
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Character>().Hit(damage);
            Debug.Log("아군에게 피해");
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "EnterDoor")
        {
            gameObject.SetActive(false);
        }
    }




}
