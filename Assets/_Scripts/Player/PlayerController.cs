using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;

public class PlayerController : MovementEventController
{
    [SerializeField] private SpriteRenderer character;
    private Camera _camera;

    /// <summary>  
    /// ��ũ��Ʈ�� ó������  
    /// ���� ī�޶� ���̾��Ű���� ã�� �Ҵ��ϴ� �޼���  
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
