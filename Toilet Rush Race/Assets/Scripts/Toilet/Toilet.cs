using System;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour
{
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    [SerializeField] private CreatorBrush _creatorBrush;
    [SerializeField] private DrawHandler _drawHandler;
    [field:SerializeField] public ToiletTrigger ToiletTrigger { get; private set; }
    private RemoveBrushHandler _removeBrushHandler;
    public event Action OnSuccessfulReach;
    [field: SerializeField] public Gender Gender { get; private set; }
    private void Awake()
    {
        //_drawHandler.OnStopDrawing += TrySavingWay;
       /* List<ISafeBrushConditional> safeBrushConditionals = new List<ISafeBrushConditional>()
        {
         new ToiletCheckerGender(_chooserCurrentCharacter, Gender),
         new MouseContactOfToilet(ToiletTrigger)
        };
        _removeBrushHandler = new RemoveBrushHandler(safeBrushConditionals, _creatorBrush);*/
    }
    public bool TrySavingWay()
    {
        Debug.Log("TOILET " + transform.position);
        if (_removeBrushHandler.CanRemove() == false)
        {
            OnSuccessfulReach?.Invoke();
            return true;
        }
        return false;
    }
    private void OnDisable()
    {
       // _drawHandler.OnStopDrawing -= TrySavingWay;
    }
}
