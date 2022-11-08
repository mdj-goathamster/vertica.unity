using System;
using UnityEditorInternal;
using UnityEngine;
using Random = UnityEngine.Random;

namespace @_
{
    [Serializable]
    public class Unit
    {
        private UnitSettings _settings;
    
        private Vector3 _position;
        private Vector3 _direction;
        private float _directionChangeTimer = 0;

        public Vector3 Position => _position;
        public Vector3 Direction => _direction;

        public Unit(UnitSettings settings)
        {
            _settings = settings;
            _position = Vector3.zero;
            ChangeDirection();
        }

        public void Tick(float deltaTime)
        {
            UpdatePosition(deltaTime);
            _directionChangeTimer += deltaTime;
            if (_directionChangeTimer > _settings.keepHeadingFor)
            {
                ChangeDirection();
            }
        }

        private void UpdatePosition(float deltaTime)
        {
            _position += _direction * _settings.moveSpeed * deltaTime;
            PositionChanged?.Invoke(_position);
        }

        private void ChangeDirection()
        {
            _direction = Random.insideUnitCircle;
            _directionChangeTimer = 0;
        }

        public event Action<Vector3> PositionChanged;
    }
}