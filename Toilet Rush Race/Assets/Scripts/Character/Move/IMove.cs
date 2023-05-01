using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    public void Move();
    public IReturnVector ReturnVector { get; }
}
