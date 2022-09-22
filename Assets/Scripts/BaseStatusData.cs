using UnityEngine;

[CreateAssetMenu(fileName = "BaseStatusData", menuName = "ScriptableObjects/BaseStatusData", order = 1)]
public class BaseStatusData : ScriptableObject
{
    public float damage;
    public float hp;
    public float defence;
    public float attackSpeed;
    public float moveSpeed;
}
