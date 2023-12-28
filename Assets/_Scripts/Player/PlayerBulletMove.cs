using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerBulletMove : MonoBehaviour
{
    private Vector3 direction;
    private float damage = 10;
    private void OnEnable()
    {
        direction = transform.parent.parent.GetChild(0).gameObject.GetComponent<CharacterAction>().GetCharacter().flipX ? new Vector2(-0.1f, 0) : new Vector2(0.1f, 0);
        transform.position = transform.parent.parent.GetChild(0).position;
        
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position += direction;
    }
    
    private void OnCollisionEnter2D(Collision2D collision) //collision이 Tag 조건에 만족한다면 BOOM!!
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Character>().Hit(damage);
            Debug.Log("적에게 피해");
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "EnterDoor")
        {
            gameObject.SetActive(false);
        } 
    }
}
