using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_MoveToPointState : StateMachineBehaviour
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

    
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        brain.Movement.MoveTo();
    }
    #endregion
}
