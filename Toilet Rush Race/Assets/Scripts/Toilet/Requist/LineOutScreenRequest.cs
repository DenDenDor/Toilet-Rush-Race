using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class LineOutScreenRequest : ISafeBrushConditional
{
    private readonly CreatorBrush _creatorBrush;
    private readonly float _raduis = 7;
    private readonly Transform _center;
    public LineOutScreenRequest(CreatorBrush creatorBrush, Transform center)
    {
        _creatorBrush = creatorBrush;
        _center = center;
    }
    public bool CanSaveBrush()
    {
        LineRenderer lineRenderer = _creatorBrush.CurrentBrush.CurrentLineRenderer;
        Vector3[] points = new Vector3[lineRenderer.positionCount];
        lineRenderer.GetPositions(points);
        bool isInRadius = points.All(e => Vector3.Distance(e, _center.position) < _raduis);
        return isInRadius;
    }

    
}
