using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    #region Inspector

    public BaseStatusData baseStatusData;

    #endregion

    private void Awake()
    {

    }

    private void Update()
    {
        transform.localPosition += Vector3.right * Time.deltaTime * baseStatusData.moveSpeed;
        if (CheckBeyondMap())
        {
            this.gameObject.SetActive(false);
        }
    }

    private bool CheckBeyondMap() => transform.localPosition.x >= 10;
}
