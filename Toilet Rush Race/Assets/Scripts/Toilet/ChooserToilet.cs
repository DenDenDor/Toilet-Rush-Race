using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooserToilet : MonoBehaviour
{
    [SerializeField] private DrawHandler _drawHandler;
    [field: SerializeField] public List<Toilet> Toilets { get; private set; }
    public Toilet CurrentToilet { get; private set; }
    private void Awake()
    {
        Toilets.ForEach(e => e.ToiletTrigger.OnEnterMouse += ChooseToilet);
    }
    private void Start()
    {
        _drawHandler.OnStopDrawing += ResetToilet;
    }
    private void ResetToilet() => CurrentToilet = null;
    private void ChooseToilet(ToiletTrigger toiletTrigger)
    {
        CurrentToilet = Toilets.Find(e => e.ToiletTrigger == toiletTrigger);
    }
    private void OnDisable()
    {
        Toilets.ForEach(e => e.ToiletTrigger.OnEnterMouse -= ChooseToilet);
        _drawHandler.OnStopDrawing -= ResetToilet;
    }
}
