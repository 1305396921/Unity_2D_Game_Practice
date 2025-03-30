using UnityEngine;

public class PlayerJumpState : PlayerState
{
    private int jumpForce = 15;
    public PlayerJumpState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    public override void Exit()
    {
        base.Exit();
        player.SetZeroVelocity();
    }

    public override void Update()
    {
        base.Update();
        if (rb.linearVelocity.y < 0)
        {
            stateMachine.ChangeState(player.airState);
        }
        if (xInput != 0)
        {
            player.SetVelocity(xInput * .8f * 12, rb.linearVelocity.y);
        }
    }
}
