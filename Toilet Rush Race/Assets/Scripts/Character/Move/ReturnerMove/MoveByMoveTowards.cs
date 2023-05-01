using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class MoveByMoveTowards : IReturnVector
{
    private Vector3 _currentPoint;
    private int _currentIndex;
    private readonly Transform _transform;
    private readonly float _speed;
    private readonly float _raduis = 0.5f;
    private readonly List<Vector3> _points = new List<Vector3>();
    public MoveByMoveTowards(Transform transform, List<Vector3> points, float speed)
    {
        _speed = speed;
        _transform = transform;
        _points = points;
        _currentPoint = _points.FirstOrDefault();
    }
    public Vector3 ReturnVector()
    {
        if (_currentPoint == _transform.position && _currentIndex < _points.Count - 1)
        {
            _currentIndex++;
            _currentPoint = _points[_currentIndex];
        }
       return Vector3.MoveTowards(_transform.position, _currentPoint, _speed * Time.deltaTime);
    }
}