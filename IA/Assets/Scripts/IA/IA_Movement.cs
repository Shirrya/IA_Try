using System;
using UnityEngine;

public class IA_Movement : MonoBehaviour
{
    #region Event
    public Action OnTargetReached = null;
    #endregion

    #region F/P
    Vector3 target = Vector3.zero;
    bool isAtTarget = false;
    #endregion

    #region CustomMethod
    public void SetTarget(Vector3 _target)
    {
        target = _target;
    }

    public void MoveTo()
    {
        if (Vector3.Distance(transform.position, target) < 0.5f)
        {
            OnTargetReached?.Invoke();
            return;
        }
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * 2);
        transform.LookAt(target);
    }
    public void MoveToPlayer()
    {
        
    }
    #endregion

}
