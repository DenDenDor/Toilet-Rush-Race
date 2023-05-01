using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CreatorBrushWay : MonoBehaviour
{
    [SerializeField] private Brush _brush;
    private void Awake()
    {
        _brush.OnSetUp += CreateBrushWay;
    }
    private void CreateBrushWay()
    {
        _brush.BrushWay = new BrushWay(_brush.CurrentLineRenderer);
        _brush.BrushWay.SetBrushWay();
    }
    private void OnDisable()
    {
        _brush.OnSetUp -= CreateBrushWay;
    }

}
