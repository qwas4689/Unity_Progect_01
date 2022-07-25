using UnityEngine;

public static class PlayerAnimID
{
    public static readonly int Run = Animator.StringToHash("isRun");
    public static readonly int Walk = Animator.StringToHash("isWalk");
    public static readonly int Jump = Animator.StringToHash("isJump");
    public static readonly int DoJump = Animator.StringToHash("DoJump");
    public static readonly int DoRoll = Animator.StringToHash("DoRoll");
}