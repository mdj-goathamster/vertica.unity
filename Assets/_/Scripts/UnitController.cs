using System.Collections.Generic;
using UnityEngine;

namespace @_
{
    public class UnitController : MonoBehaviour
    {
        [SerializeField] private UnitView _viewPrefab;
        [SerializeField] private List<UnitSettings> _settings;
        private List<Unit> _units;
        private List<UnitView> _unitViews;
    
    
        private void Start()
        {
            _units = new List<Unit>();
            foreach (var unitSettings in _settings)
            {
                var unit = new Unit(unitSettings);
                _units.Add(unit);
                var view = Instantiate(_viewPrefab, transform);
                view.Setup(unit);
            }
        }

        private void Update()
        {
            foreach (var unit in _units)
            {
                unit.Tick(Time.deltaTime);
            }
        }
    }
}