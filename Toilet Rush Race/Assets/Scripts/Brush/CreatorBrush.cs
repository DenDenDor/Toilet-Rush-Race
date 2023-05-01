using System;
using System.Collections.Generic;
using UnityEngine;

public class CreatorBrush : MonoBehaviour
{
    [SerializeField] private Brush _brush;
    [SerializeField] private StarterDrawingState _drawing;
    [SerializeField] private NewBrushHandler _newBrushHandler;
    [SerializeField] private DrawHandler _drawHandler;
    [field: SerializeField] public ChooserCurrentCharacter ChooserCurrentCharacter { get; private set; }
    public Brush CurrentBrush { get; private set; }
    public event Action OnCreateBrush;
    private void Awake()
    {
        _newBrushHandler = new NewBrushHandler(ChooserCurrentCharacter);
        _drawing.OnTryDrawing += CreateBrush;
    }
    private void Start()
    {
        _drawHandler.OnStopDrawing += TurnOff;
    }
    private void TurnOff() => CurrentBrush = null;
    private void CreateBrush()
    {
        if (_newBrushHandler.CanCreate())
        {
            CurrentBrush = Instantiate(_brush);
            OnCreateBrush?.Invoke();
        }
    }
    private void OnDisable()
    {
        _drawing.OnTryDrawing -= CreateBrush;
        _drawHandler.OnStopDrawing -= TurnOff;
    }

}
