using UnityEngine;

namespace @_
{
    public class Unit2 : MonoBehaviour
    {
        public float moveSpeed = 5;
        public float keepHeadingDuration = 2;

        private float _headingTimer;
        private Vector3 _direction;
    
        void Start()
        {
            _direction = Random.insideUnitCircle;
            _headingTimer = 0;
        }

        void Update()
        {
            if (_headingTimer > keepHeadingDuration)
            {
                _direction = Random.insideUnitCircle;
                _headingTimer = 0;
            }
            _headingTimer += Time.deltaTime;
        
            transform.Translate(_direction * moveSpeed * Time.deltaTime);
        }
    }
}