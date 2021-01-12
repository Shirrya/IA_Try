using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_GetPointState : StateMachineBehaviour
{
    #region Event
    #endregion

    #region F/P
    IA_Brain brain = null;
#endregion
#region UnityMethod
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
#endregion

#region CustomMethod
    public void InitState(IA_Brain _brain)
    {
        brain = _brain;
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector3 random = brain.Pattern.GetRandomPoint();
        brain.Movement.SetTarget(random);
        brain.Fsm.SetBool("moving", true);
        brain.BodyAnims.SetBool("moving", true);
    }
    #endregion
}
