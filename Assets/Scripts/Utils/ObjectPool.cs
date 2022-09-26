using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
	#region Inspector

	public GameObject original;
	public int count;

	#endregion

	private List<GameObject> _pool = null;

	private void Awake()
	{
		// ���� ����
		if (original != null)
		{
			_pool = new List<GameObject>(capacity: count);
			for (int i = 0; i < count; i++)
			{
				var gameObject = Create();
				gameObject.SetActive(false);
                _pool.Add(gameObject);
			}
		}
    }

	/// <summary>
	/// Ǯ���� ��������
	/// </summary>
	/// <returns></returns>
	public GameObject Get()
	{
		// 1. ���� Ǯ���� ��Ȱ��ȭ�� ������Ʈ�� �ִ��� Ȯ���Ѵ�.
		for (int i = 0; i < _pool.Count; i++)
		{
			var gameObject = _pool[i];
			if (!gameObject.activeInHierarchy)
				return gameObject;
        }

		// 2. Ǯ���� ���� ��� ���� �����Ѵ�.
		var newGameObject = Create();
		if (newGameObject != null)
		{
			_pool.Add(newGameObject);
			return newGameObject;
		}

		return null;
	}

	/// <summary>
	/// ������Ʈ ���� �����ϱ�
	/// </summary>
	/// <returns></returns>
	private GameObject Create()
	{
		if (original != null)
		{
			var gameObject = Instantiate<GameObject>(original);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
			gameObject.transform.localScale = Vector3.one;
            return gameObject;
        }
		return null;
	}
}
