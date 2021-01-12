using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_ChaseState : StateMachineBehaviour
{
    #region Event
    #endregion

    #region F/P
    IA_Brain brain = null;
    #endregion

    #region CustomMethod
    public void InitState(IA_Brain _brain)
    {
        brain = _brain;
    }
    #endregion
}
