using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayerEndGameScreen : MonoBehaviour
{
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    [SerializeField] private GameObject _screen;
    private void Awake()
    {
        _chooserCurrentCharacter.ClickableCharacters.ForEach(e => e.Character.CharacterTrigger.OnTriggerCharacter += DisplayEndGameScreen);
    }
    private void DisplayEndGameScreen() => _screen.SetActive(true);
    private void OnDisable()
    {
        _chooserCurrentCharacter.ClickableCharacters.ForEach(e => e.Character.CharacterTrigger.OnTriggerCharacter -= DisplayEndGameScreen);
    }
}
