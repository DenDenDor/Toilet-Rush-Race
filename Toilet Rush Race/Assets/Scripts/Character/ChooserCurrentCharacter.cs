using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooserCurrentCharacter : MonoBehaviour
{
    [SerializeField] private DrawHandler _drawHandler;
    [field: SerializeField] public List<ClickableCharacter> ClickableCharacters { get; private set; }
    public ClickableCharacter ClickableCharacter { get; private set; }
    private void Awake()
    {
        ClickableCharacters.ForEach(e => e.OnClick += Choose);
    }
    private void Start()
    {
        _drawHandler.OnStopDrawing += ResetClickableCharacter;
    }
    private void ResetClickableCharacter() => ClickableCharacter = null;
    private void Choose(ClickableCharacter clickableCharacter)
    {
        ClickableCharacter = clickableCharacter;
    }
    private void OnDisable()
    {
        ClickableCharacters.ForEach(e => e.OnClick -= Choose);
        _drawHandler.OnStopDrawing -= ResetClickableCharacter;
    }
}
