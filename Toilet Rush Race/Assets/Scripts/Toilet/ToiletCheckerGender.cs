using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletCheckerGender : ISafeBrushConditional
{
    private readonly Dictionary<Gender, IGenderHandler> _dictionary = new Dictionary<Gender, IGenderHandler>();
    private readonly ChooserCurrentCharacter _chooserCurrentCharacter;
    private readonly ChooserToilet _chooserToilet;
    public ToiletCheckerGender(ChooserCurrentCharacter chooserCurrentCharacter, ChooserToilet chooserToilet)
    {
        _chooserToilet = chooserToilet;
        _chooserCurrentCharacter = chooserCurrentCharacter;
        _dictionary.Add(Gender.Female, new SimpleGender(Gender.Female));
        _dictionary.Add(Gender.Male, new SimpleGender(Gender.Male));
        _dictionary.Add(Gender.Both, new BothGender());
    }
    public bool CanSaveBrush()
    {
        if (_chooserToilet.CurrentToilet == null)
        {
            return false;
        }
        return _dictionary[_chooserToilet.CurrentToilet.Gender].IsPossibleGender(_chooserCurrentCharacter.ClickableCharacter.Gender);
    }
}
