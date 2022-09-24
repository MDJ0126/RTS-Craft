using UnityEngine;

[CreateAssetMenu(fileName = "BaseStatusData", menuName = "ScriptableObjects/BaseStatusData", order = 1)]
public class BaseStatusData : ScriptableObject
{
    /// <summary>
    /// 공격력
    /// </summary>
    public float damage;
    /// <summary>
    /// 체력
    /// </summary>
    public float maxHp;
    /// <summary>
    /// 방어력
    /// </summary>
    public float defence;
    /// <summary>
    /// 공격 속도
    /// </summary>
    public float attackSpeed;
    /// <summary>
    /// 이동 속도
    /// </summary>
    public float moveSpeed;
}
