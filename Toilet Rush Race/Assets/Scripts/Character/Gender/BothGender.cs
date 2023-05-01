using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BothGender : IGenderHandler
{
    public bool IsPossibleGender(Gender gender) => gender == Gender.Male || gender == Gender.Female;
    
}
