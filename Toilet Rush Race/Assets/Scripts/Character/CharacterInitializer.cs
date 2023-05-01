using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInitializer : MonoBehaviour
{
    [field: SerializeField] public Character Character { get; private set; }
    [field: SerializeField] public GetterMove GetterMove { get; private set; }
    private void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        Character.Initialize(GetterMove.GetMove());
    }
}
