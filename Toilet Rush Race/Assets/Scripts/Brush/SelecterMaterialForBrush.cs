using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecterMaterialForBrush : MonoBehaviour
{
    [SerializeField] private Material _boyMaterial;
    [SerializeField] private Material _girlMaterial;
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    public bool IsMaleGender { get; private set; }
    public Material ReturnCurrentMaterial()
    {
        IsMaleGender = _chooserCurrentCharacter.ClickableCharacter.Character is Boy;
        return IsMaleGender ? _boyMaterial : _girlMaterial;
    }

    }
