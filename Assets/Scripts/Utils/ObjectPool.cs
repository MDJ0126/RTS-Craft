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
		// 최초 세팅
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
	/// 풀에서 가져오기
	/// </summary>
	/// <returns></returns>
	public GameObject Get()
	{
		// 1. 먼저 풀에서 비활성화된 오브젝트가 있는지 확인한다.
		for (int i = 0; i < _pool.Count; i++)
		{
			var gameObject = _pool[i];
			if (!gameObject.activeInHierarchy)
				return gameObject;
        }

		// 2. 풀에서 없는 경우 새로 생성한다.
		var newGameObject = Create();
		if (newGameObject != null)
		{
			_pool.Add(newGameObject);
			return newGameObject;
		}

		return null;
	}

	/// <summary>
	/// 오브젝트 새로 생성하기
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
