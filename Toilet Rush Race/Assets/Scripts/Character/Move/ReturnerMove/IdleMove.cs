using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMove : IReturnVector
{
    private readonly Transform _transform;
    public IdleMove(Transform transform)
    {
        _transform = transform;
    }
    public Vector3 ReturnVector() => _transform.position;
}
