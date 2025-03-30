using UnityEngine;

public class PlayerMoveState : PlayerGroundedState
{
    private int movespeed = 12;
    public PlayerMoveState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
        if (xInput == 0)
        {
            stateMachine.ChangeState(player.idleState);
        }

        player.SetVelocity(xInput * movespeed, rb.linearVelocity.y);
    }

    public override void Exit()
    {
        base.Exit();
    }

    
}
