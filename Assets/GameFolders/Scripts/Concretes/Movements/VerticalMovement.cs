using Game3D.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game3D.Movements
{
    public class VerticalMovement 
    {
        EnemyController _enemyController;
        float _moveSpeed;

        public VerticalMovement(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = _enemyController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)
        {
            _enemyController.transform.Translate(Vector3.back * vertical * _moveSpeed * Time.deltaTime);
        }

    
    }

}
