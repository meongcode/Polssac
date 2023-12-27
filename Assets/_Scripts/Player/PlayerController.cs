using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;

public class PlayerController : MovementEventController
{
    [SerializeField] private SpriteRenderer character;
    private Camera _camera;

    /// <summary>  
    /// 스크립트가 처음으로  
    /// 메인 카메라를 하이어라키에서 찾아 할당하는 메서드  
    /// </summary>  
    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Start()
    {
        GameManager.Instance.PlayerTranform(gameObject);
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveValue = value.Get<Vector2>().normalized;
        CallMoveEvent(moveValue);
    }

    public void OnLookForward(InputValue value)
    {
        Vector2 LookValue = value.Get<Vector2>().normalized;
        CallLookForwardEvent(LookValue);
    }
    public void OnAttack()
    {
        CallAttackEvent();
    }
    public void OnJump()
    {
        CallJumpEvent();
    }
    public void OnEffect()
    {
        CallEffectEvent();
    }
}
