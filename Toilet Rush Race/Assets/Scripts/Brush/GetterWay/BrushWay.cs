using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BrushWay : MonoBehaviour
{
    public float Distance { get; private set; }
    public Vector3[] ListOfPoints { get; private set; }
    private LineRenderer _lineRenderer;
    public BrushWay(LineRenderer lineRenderer)
    {
        _lineRenderer = lineRenderer;
    }
    public void SetBrushWay()
    {
        LineRenderer oldLineComponent = _lineRenderer;
        ListOfPoints = new Vector3[oldLineComponent.positionCount];
        oldLineComponent.GetPositions(ListOfPoints);
        for (int i = 0; i < ListOfPoints.Length - 1; i++)
        {
            Distance += Vector3.Distance(ListOfPoints[i], ListOfPoints[i + 1]);
        }
    }
}
