using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseContactOfToilet : ISafeBrushConditional
{
    private readonly ChooserToilet _chooserToilet;
    public MouseContactOfToilet(ChooserToilet chooserToilet)
    {
        _chooserToilet = chooserToilet;
    }
    public bool CanSaveBrush()
    {
        if (_chooserToilet.CurrentToilet != null)
        {
          return _chooserToilet.CurrentToilet.ToiletTrigger.IsEnteredMouse;
        }
        return false;
    }
    
}
