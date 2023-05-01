using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdderMousePositionToBrush : MonoBehaviour
{
    [SerializeField] private DrawHandler _drawHandler;
    [SerializeField] private Camera _camera;
    [SerializeField] private CreatorBrush _creatorBrush;
    private Vector2 _lastPosition;
    private void Awake()
    {
        _drawHandler.OnDraw += PointToMousePos;
    }
    private void PointToMousePos()
    {
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        if (_lastPosition != mousePosition)
        {
            _creatorBrush.CurrentBrush.AddPoint(mousePosition);
            _lastPosition = mousePosition;
        }
    }
    private void OnDisable()
    {
        _drawHandler.OnDraw -= PointToMousePos;
    }

}
