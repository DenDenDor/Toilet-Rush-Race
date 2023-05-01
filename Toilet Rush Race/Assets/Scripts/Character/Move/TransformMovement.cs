using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : IMove
{
    private Transform _transform;
    public IReturnVector ReturnVector { get; private set; }
    public TransformMovement(Transform transform, IReturnVector returnVector)
    {
        _transform = transform;
        ReturnVector = returnVector;
    }
    public void Move()
    {
        _transform.position = ReturnVector.ReturnVector();
    }

    

}
