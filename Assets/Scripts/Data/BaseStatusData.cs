using UnityEngine;

[CreateAssetMenu(fileName = "BaseStatusData", menuName = "ScriptableObjects/BaseStatusData", order = 1)]
public class BaseStatusData : ScriptableObject
{
    /// <summary>
    /// ���ݷ�
    /// </summary>
    public float damage;
    /// <summary>
    /// ü��
    /// </summary>
    public float maxHp;
    /// <summary>
    /// ����
    /// </summary>
    public float defence;
    /// <summary>
    /// ���� �ӵ�
    /// </summary>
    public float attackSpeed;
    /// <summary>
    /// �̵� �ӵ�
    /// </summary>
    public float moveSpeed;
}
