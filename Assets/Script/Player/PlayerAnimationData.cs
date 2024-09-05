using System;
using UnityEngine;

[Serializable]
public class PlayerAnimationData
{
    [SerializeField] private string idleParameterName = "Idle";

    [SerializeField] private string attackParameterName = "Attack";


    public int IdleParameterHash { get; private set; }

    public int AttackParameterHash { get; private set; }

    public void Initialize()
    {
        IdleParameterHash = Animator.StringToHash(idleParameterName);

        AttackParameterHash = Animator.StringToHash(attackParameterName);
    }
}

