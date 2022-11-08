using UnityEngine;

namespace @_
{
    public class Unit3: MonoBehaviour
    {
        public float moveSpeed = 5;
        public float keepHeadingFrames = 60;

        private Vector3 _direction;
    
        void Start()
        {
            _direction = Random.insideUnitCircle;
        }

        void Update()
        {
            transform.Translate(_direction * moveSpeed * Time.deltaTime);

            if (Time.frameCount % keepHeadingFrames == 0)
            {
                _direction = Random.insideUnitCircle;
            }
        }
    }
}