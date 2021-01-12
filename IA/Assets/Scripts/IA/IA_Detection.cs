using System;
using UnityEngine;

public class IA_Detection : MonoBehaviour
{
    #region Event
    public Action OnPlayerDetected = null;
    #endregion

    #region F/P
    Vector3 player = Vector3.zero;
    #endregion

    #region CustomMethod
    public void Detect()
    {
        if (Vector3.Distance(transform.position, player) < 4)
            OnPlayerDetected?.Invoke();
    }
    #endregion
}
