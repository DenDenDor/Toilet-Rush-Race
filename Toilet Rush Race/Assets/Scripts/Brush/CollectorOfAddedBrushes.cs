using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorOfAddedBrushes : MonoBehaviour
{
    [SerializeField] private DestroyerBrush _destroyerBrush;
    [SerializeField] private CreatorBrush _creatorBrush;
    public List<Brush> Brushes { get; private set; } = new List<Brush>();
    private void Awake()
    {
        _destroyerBrush.OnAddBrushSuccesful += AddBrush;
    }
    private void AddBrush() => Brushes.Add(_creatorBrush.CurrentBrush);
    private void OnDisable()
    {
        _destroyerBrush.OnAddBrushSuccesful -= AddBrush;
    }
}
