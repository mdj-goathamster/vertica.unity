using System.Collections;
using UnityEngine;

namespace @_
{
    public class Unit1: MonoBehaviour
    {
        public float moveSpeed = 5;
        public float keepHeadingDuration = 2;

        private Vector3 _direction;
    
        void Start()
        {
            StartCoroutine(UpdateHeading());
        }

        IEnumerator UpdateHeading()
        {
            while (true)
            {
                _direction = Random.insideUnitCircle;
                yield return new WaitForSeconds(keepHeadingDuration);
            }
        }

        void Update()
        {
            transform.Translate(_direction * moveSpeed * Time.deltaTime);
        }
    }
}