using System;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public BrushWay BrushWay { get; set; }
    [field: SerializeField] public LineRenderer CurrentLineRenderer { get; private set; }
    public event Action OnSetUp;
    public void SetMaterial(Material material) => CurrentLineRenderer.material = material; 
    public void AddPoint(Vector2 pointPosition)
    {
        CurrentLineRenderer.positionCount++;
        int positionIndex = CurrentLineRenderer.positionCount - 1;
        CurrentLineRenderer.SetPosition(positionIndex, pointPosition);
    }
    public void SetUp() =>  OnSetUp?.Invoke();

}
