using System;
using System.Collections.Generic;
using UnityEngine;
public enum Gender
{
    Male,
    Female,
    Both
}
public class ClickableCharacter : MonoBehaviour
{
    [field:SerializeField] public Character Character { get; private set; }
    public bool WasChoosen { get; private set; } = false;
    public event Action<ClickableCharacter> OnClick;
    [field:SerializeField] public Gender Gender { get; private set; }
    public void Click()
   {
        OnClick?.Invoke(this);
    }
    public void GetMouseButtonUp() => WasChoosen = true;
}
