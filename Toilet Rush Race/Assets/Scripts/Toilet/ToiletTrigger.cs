using System;
using System.Collections.Generic;
using UnityEngine;

public class ToiletTrigger : MonoBehaviour
{
    public event Action<ToiletTrigger> OnEnterMouse;
    public bool IsEnteredMouse { get; private set; }
    public void EnterMouse()
    {
        OnEnterMouse?.Invoke(this);
        IsEnteredMouse = true;
    }

    public void ExitMouse() => IsEnteredMouse = false;

}
