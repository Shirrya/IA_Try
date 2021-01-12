using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Brain : MonoBehaviour
{
    #region Event
    #endregion

    #region F/P
    [SerializeField] Animator fsm = null;
    [SerializeField] Animator bodyAnims = null;
    public Animator BodyAnims => bodyAnims;
    public Animator Fsm => fsm;
    public IA_Movement Movement { get; private set; } = null;
    public IA_Pattern Pattern { get; private set; } = null;
    public IA_Detection Detection { get; private set; } = null;
    IA_MoveToPointState moveToPointState = null;
    IA_GetPointState getPointState = null;
    #endregion
    #region UnityMethod
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }
    #endregion

    #region CustomMethod
    void Init()
    {
        Movement = GetComponent<IA_Movement>();
        Pattern = GetComponent<IA_Pattern>();
        Detection = GetComponent<IA_Detection>();
        getPointState = fsm.GetBehaviour<IA_GetPointState>();
        moveToPointState = fsm.GetBehaviour<IA_MoveToPointState>();
        getPointState.InitState(this);
        moveToPointState.InitState(this);
        Movement.OnTargetReached += () => fsm.SetBool("moving", false);
        Movement.OnTargetReached += () => bodyAnims.SetBool("moving", false);
        Detection.OnPlayerDetected += () => fsm.SetBool("playerInRange", true);
    }
    #endregion
}
