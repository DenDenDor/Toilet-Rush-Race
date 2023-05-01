using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : MonoBehaviour
{
    [field: SerializeField] public float Time { get; private set; } = 4;
    public IMove Move { get; private set; }
    public IReturnVector ReturnVector { get; set; }
    private void Awake()
    {
        ReturnVector = new IdleMove(transform);
    }
    public IMove GetMove()
    {
      return Move = new TransformMovement(transform, ReturnVector);
    }
}
