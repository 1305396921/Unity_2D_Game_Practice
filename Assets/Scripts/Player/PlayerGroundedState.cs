using System.Threading;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    private int counterAttackCD = 1;
    private float counterAttackCDTimer;

    public PlayerGroundedState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        
        if (!player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.airState);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            stateMachine.ChangeState(player.aimSwordState);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            stateMachine.ChangeState(player.primaryAttackState);
        }
        if (Input.GetKeyDown(KeyCode.Space) && player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.jumpState);
        }
        CheckForCounterInput();
        
        
    }
    private void CheckForCounterInput()
    {
        counterAttackCDTimer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q) && counterAttackCDTimer < 0)
        {
            counterAttackCDTimer = counterAttackCD;
            stateMachine.ChangeState(player.counterAttackState);
        }
    }
}
