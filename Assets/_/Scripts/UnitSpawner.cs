using System.Collections.Generic;
using UnityEngine;

namespace @_
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField] private int spawnCount;
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _container;

        private void Start()
        {
            for (int i = 0; i < spawnCount; i++)
            {
                Instantiate(_unitPrefab, _container);
            }
        }
    }


    public class UnitSpawnerWithSettings : MonoBehaviour
    {
        [SerializeField] private int spawnCount;
        [SerializeField] private UnitView _unitPrefab;
        [SerializeField] private Transform _container;

        private void Start()
        {
            for (int i = 0; i < spawnCount; i++)
            {
                Instantiate(_unitPrefab, _container);
            }
        }
    }
}