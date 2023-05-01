using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedCharacterRequest : IPossibleRequest
{
    private readonly ChooserCurrentCharacter _chooserCurrentCharacter;
    public ClickedCharacterRequest(ChooserCurrentCharacter chooserCurrentCharacter)
    {
        _chooserCurrentCharacter = chooserCurrentCharacter;
    }
    public bool CanCreateBrush()
    {
        if (_chooserCurrentCharacter.ClickableCharacter == null)
        {
            return false;
        }
       return _chooserCurrentCharacter.ClickableCharacter.WasChoosen == false;
    }
}
