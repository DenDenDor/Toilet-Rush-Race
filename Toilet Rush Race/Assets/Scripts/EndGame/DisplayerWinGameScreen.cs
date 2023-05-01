using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayerWinGameScreen : MonoBehaviour
{
    [SerializeField] private GameObject _screen;
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    private int _countOfReachedCharacters;
    private void Awake()
    {
        _chooserCurrentCharacter.ClickableCharacters.ForEach(e => e.Character.CharacterTrigger.OnTriggerToilet += DisplayWinGameScreen);
    }
    private void DisplayWinGameScreen()
    {
        _countOfReachedCharacters++;
        Debug.Log("TRIGGER " + _countOfReachedCharacters);
        if (_countOfReachedCharacters >= _chooserCurrentCharacter.ClickableCharacters.Count)
        {
            _screen.SetActive(true);
        }
    }
   private void OnDisable()
    {
        _chooserCurrentCharacter.ClickableCharacters.ForEach(e => e.Character.CharacterTrigger.OnTriggerToilet -= DisplayWinGameScreen);
    }

}
