using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorOfAddedCharacters : MonoBehaviour
{
    [SerializeField] private DestroyerBrush _destroyerBrush;
    [SerializeField] private ChooserCurrentCharacter _chooserCurrentCharacter;
    public List<Character> Characters { get; private set; } = new List<Character>();
    private void Awake()
    {
        _destroyerBrush.OnAddBrushSuccesful += AddCharacter;
    }
    private void AddCharacter() => Characters.Add(_chooserCurrentCharacter.ClickableCharacter.Character);
    private void OnDisable()
    {
        _destroyerBrush.OnAddBrushSuccesful -= AddCharacter;
    }
}
