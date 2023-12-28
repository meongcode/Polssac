using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class MovementEventController : MonoBehaviour
{
    public event Action<Vector2> MoveEvent; // Move Event Action  
    public event Action<Vector2> LookForwardEvent; // Rotate Event Action  
    public event Action AttackEvent;
    public event Action EffectEvent;
    public event Action JumpEvent;

    /// <summary>  
    /// 케릭터가 움직일 때 호출 되는 Move Event 메서드  
    /// </summary>  
    /// <param name="value">2D 평면 이동 Vector2 값</param>  
    protected void CallMoveEvent(Vector2 value)
    {
        MoveEvent?.Invoke(value);
    }
    protected void CallLookForwardEvent(Vector2 value)
    {
        LookForwardEvent?.Invoke(value);
    }
    protected void CallAttackEvent()
    {
        AttackEvent?.Invoke();
    }
    protected void CallJumpEvent()
    {
        JumpEvent?.Invoke();
    }
    protected void CallEffectEvent()
    {
        EffectEvent?.Invoke();
    }
}