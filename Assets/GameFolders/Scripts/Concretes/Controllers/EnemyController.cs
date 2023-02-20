using Game3D.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game3D.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _maxLifeTime = 10f;

        VerticalMovement _movement;
        float _currentLifeTime = 0f;

        public float MoveSpeed => _moveSpeed;

        private void Awake()
        {
            _movement = new VerticalMovement(this);
        }

        private void Update()
        {
            _currentLifeTime += Time.deltaTime;

            if(_currentLifeTime > _maxLifeTime)
            {
                _currentLifeTime = 0f;
                KillYourself();
            }
        }

        private void FixedUpdate()
        {
            _movement.FixedTick();
        }


        void KillYourself()
        {
            Destroy(this.gameObject);
        }


    }

}
