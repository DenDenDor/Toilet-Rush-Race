using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopperMove : MonoBehaviour
{
    [SerializeField] private CollectorOfCharacterInitilizators _collectorOfCharacterInitilizators;
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    private void Awake()
    {
        _chooserCurrentCharacter.ClickableCharacters.ForEach(e => e.Character.CharacterTrigger.OnTriggerCharacter += EndMove);
    }
    private void EndMove()
    {
        _collectorOfCharacterInitilizators.CharacterInitializers.ForEach(e => _collectorOfCharacterInitilizators.Initialize(e, new IdleMove(e.transform)));
    }
    private void OnDisable()
    {
        _chooserCurrentCharacter.ClickableCharacters.ForEach(e => e.Character.CharacterTrigger.OnTriggerCharacter -= EndMove);
    }
}
