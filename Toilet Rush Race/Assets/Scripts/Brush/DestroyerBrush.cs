using System;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBrush : MonoBehaviour
{
    [SerializeField] private Transform _center;
    [SerializeField] private DrawHandler _drawHandler;
    [SerializeField] private ChooserToilet _chooserToilet;
    [SerializeField] private CreatorBrush _creatorBrush;
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    public event Action OnAddBrushSuccesful;
    private void Awake()
    {
        _drawHandler.OnStopDrawing += TryDestroyingBrush;
    }
    private void TryDestroyingBrush()
    {
        List<ISafeBrushConditional> safeBrushConditionals = new List<ISafeBrushConditional>()
        {
         new ToiletCheckerGender(_creatorBrush.ChooserCurrentCharacter, _chooserToilet),
         new MouseContactOfToilet(_chooserToilet),
         new LineOutScreenRequest(_creatorBrush, _center)
        };
        RemoveBrushHandler removeBrushHandler = new RemoveBrushHandler(safeBrushConditionals, _creatorBrush, _chooserCurrentCharacter);
        if(removeBrushHandler.CanRemove() == false)
        {
            OnAddBrushSuccesful?.Invoke();
        }
    }
    private void OnDisable()
    {
        _drawHandler.OnStopDrawing -= TryDestroyingBrush;
    }
}
