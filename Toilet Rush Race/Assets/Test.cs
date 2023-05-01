using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private LineRenderer _brush;
    private LineRenderer _currentLineRenderer;
    private Vector2 _lastPosition;
    private void Update()
    {
        Drawing();
    }

    private void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToMousePos();
        }
        else
        {
            _currentLineRenderer = null;
        }
    }

    private void CreateBrush()
    {
        _currentLineRenderer = Instantiate(_brush);
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _currentLineRenderer.SetPosition(0, mousePosition);
        _currentLineRenderer.SetPosition(1, mousePosition);

    }

    private void AddPoint(Vector2 pointPosition)
    {
        _currentLineRenderer.positionCount++;
        int positionIndex = _currentLineRenderer.positionCount - 1;
        _currentLineRenderer.SetPosition(positionIndex, pointPosition);
    }

    private void PointToMousePos()
    {
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        if (_lastPosition != mousePosition)
        {
            AddPoint(mousePosition);
            _lastPosition = mousePosition;
        }
    }

}
