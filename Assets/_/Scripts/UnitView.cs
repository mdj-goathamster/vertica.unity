using UnityEngine;

namespace @_
{
    public class UnitView : MonoBehaviour
    {
        private Transform _transform;
        private Unit _unit;

        private void Awake()
        {
            _transform = transform;
        }

        public void Setup(Unit unit)
        {
            _unit = unit;
            _unit.PositionChanged += OnPositionChanged;
            UpdatePosition();
        }

        private void OnPositionChanged(Vector3 obj)
        {
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            _transform.position = _unit.Position;
        }
    }
}