using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterAction : MonoBehaviour
{

    private MovementEventController _movementEventController;
    private PlayerBulletMove _playBulletMove;
    public int enemyKillCount = 0;
    public bool nextToStage = false;
    public SpriteRenderer GetCharacter() { return character; }

    #region Move Variables  
    [SerializeField] private float speed;
    private Vector2 _moveDirection;
    private Vector2 _lookDirection;
    private Rigidbody2D _rigidbody2D;
    private Vector2 direction = new Vector2 (0,0);
    #endregion

    #region LookForward Variables  
    [SerializeField] private SpriteRenderer character;
    #endregion

    private void Awake()
    {
        _movementEventController = GetComponent<MovementEventController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _movementEventController.MoveEvent += Move;
        _movementEventController.LookForwardEvent += LookForward;
        _movementEventController.AttackEvent += Attack;
        _movementEventController.JumpEvent += Jump;
        _movementEventController.EffectEvent += Effect;
        Hit();
        
    }

    

    private void LateUpdate()
    {
        MoveToward(_moveDirection != Vector2.zero ? _moveDirection : Vector2.zero);
    }

    private void Move(Vector2 moveDirection) //Animation Signal -> Bool
    {
        _moveDirection = moveDirection;
    }
    private void LookForward(Vector2 lookDirection)
    {
        _lookDirection = lookDirection;

        if (_lookDirection.x > 0)
        {
            character.flipX = false;
        }
        else if (_lookDirection.x < 0)
        {
            character.flipX = true;
            
        }
    }
    private void Attack() //Animation Signal -> Trigger
    {
        
    }
    private void Jump() //Animation Signal -> Trigger
    {

    }
    private void Effect() // F 눌러서 아이템 획득
    {
        //Collider가 맞닿으면 F가 적용
    }
    private void Hit() //Animation Signal -> Trigger
    {
        //적에게 맞는 순간
    }
    private void MoveToward(Vector2 moveDirection)
    {
        Vector2 direction = moveDirection * speed;
        _rigidbody2D.velocity = direction;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnterDoor" && enemyKillCount >= 5)
        {
            nextToStage = true;
        }
    }
}

