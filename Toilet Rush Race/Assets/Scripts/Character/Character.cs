using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public IMove IMove { get; set; }
    [field: SerializeField] public CharacterTrigger CharacterTrigger { get; private set; }
    public void Initialize(IMove move)
    {
        IMove = move;
    }
    private void Update()
    {
        IMove.Move();
    }
}
