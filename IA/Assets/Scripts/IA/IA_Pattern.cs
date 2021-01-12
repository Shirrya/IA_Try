using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Pattern : MonoBehaviour
{
#region Event
#endregion

#region F/P
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
    public Vector3 GetRandomPoint()
    {
        return new Vector3(Random.Range(-10, 10), 0,Random.Range(-10,10));
    }
#endregion
}
