using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBrushHandler
{
    private readonly CreatorBrush _creatorBrush;
    private readonly ChooserCurrentCharacter _chooserCurrentCharacter;
    private readonly List<ISafeBrushConditional> _safeBrushConditionals = new List<ISafeBrushConditional>();
    public RemoveBrushHandler(List<ISafeBrushConditional> safeBrushConditionals, CreatorBrush creatorBrush, ChooserCurrentCharacter chooserCurrentCharacter)
    {
        _chooserCurrentCharacter = chooserCurrentCharacter;
        _safeBrushConditionals = safeBrushConditionals;
        _creatorBrush = creatorBrush;
    }
    public bool CanRemove()
    {
        if (_safeBrushConditionals.Any(e=>e.CanSaveBrush() == false))
        {
            MonoBehaviour.Destroy(_creatorBrush.CurrentBrush.gameObject);
            return true;
        }
        _creatorBrush.CurrentBrush.SetUp();
        _chooserCurrentCharacter.ClickableCharacter.GetMouseButtonUp();
        return false;
    }
 }
