using System;
using UnityEngine;

[Serializable]
public class MonsterAnimationData
{
    [SerializeField] private string idleParameterName = "Idle";

    [SerializeField] private string attackParameterName = "Attack";

    [SerializeField] private string walkParameterName = "Walk";

    [SerializeField] private string dieParameterName = "Die";

    [SerializeField] private string hurtParameterName = "Hurt";

    public int IdleParameterHash { get; private set; }
    public int AttackParameterHash { get; private set; }
    public int WalkParameterHash { get; private set; }
    public int DieParameterHash { get; private set; }
    public int HurtParameterHash { get; private set; }

    public void Initialize()
    {
        IdleParameterHash = Animator.StringToHash(idleParameterName);

        AttackParameterHash = Animator.StringToHash(attackParameterName);

        WalkParameterHash = Animator.StringToHash(walkParameterName);

        DieParameterHash = Animator.StringToHash(dieParameterName);

        HurtParameterHash = Animator.StringToHash(hurtParameterName);

    }
}