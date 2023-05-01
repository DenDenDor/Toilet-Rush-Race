using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorOfCharacterInitilizators : MonoBehaviour
{
    [field: SerializeField] public List<CharacterInitializer> CharacterInitializers { get; private set; } = new List<CharacterInitializer>();
    public void Initialize(CharacterInitializer characterInitializer, IReturnVector returnVector)
    {
        characterInitializer.GetterMove.ReturnVector = returnVector;
        characterInitializer.Initialize();
    }
}
