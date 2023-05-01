using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StarterMove : MonoBehaviour
{
    [SerializeField] private DecreaserOpenToilets _decreaserOpenToilets;
    [SerializeField] private CollectorOfAddedBrushes _collectorOfAddedBrushes;
    [SerializeField] private CollectorOfAddedCharacters _collectorOfAddedCharacters;
    [SerializeField] private float _waitTime = 0.5f;
    [SerializeField] private CollectorOfCharacterInitilizators _collectorOfCharacterInitilizators;
    private void Start()
    {
        _decreaserOpenToilets.OnReachEveryToilet += StartMoving;
    }
    private void StartMoving()
    {
        StartCoroutine(Move());
        
    }
    private IEnumerator Move()
    {
        yield return new WaitForSeconds(_waitTime);
        for (int i = 0; i < _collectorOfAddedCharacters.Characters.Count; i++)
        {
            CharacterInitializer characterInitializer = _collectorOfCharacterInitilizators.CharacterInitializers.Find(e => e.Character == _collectorOfAddedCharacters.Characters[i]);
            characterInitializer.GetterMove.ReturnVector
                = new MoveByMoveTowards(_collectorOfAddedCharacters.Characters[i].transform, _collectorOfAddedBrushes.Brushes[i].BrushWay.ListOfPoints.ToList(), _collectorOfAddedBrushes.Brushes[i].BrushWay.Distance / _collectorOfCharacterInitilizators.CharacterInitializers[i].GetterMove.Time);
            characterInitializer.Initialize();
        }
    }
    private void OnDisable()
    {
        _decreaserOpenToilets.OnReachEveryToilet -= StartMoving;
    }
}
