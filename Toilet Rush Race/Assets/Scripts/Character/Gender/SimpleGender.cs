using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGender : IGenderHandler
{
    private Gender _possibleGender;
    public SimpleGender(Gender possibleGender)
    {
        _possibleGender = possibleGender;
    }
    public bool IsPossibleGender(Gender gender) => gender == _possibleGender;
}
