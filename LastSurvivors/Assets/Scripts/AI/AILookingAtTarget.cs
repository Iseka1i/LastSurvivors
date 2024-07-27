using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class AILookingAtTarget : MonoBehaviour
    {
        public Transform target;
        public float viewAngle = 30.0f;
        public float distanceToTarget;

        public bool IsLookingAtTarget()
        {
            this.distanceToTarget = Vector3.Distance(transform.position, target.position);
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            float angle = Vector3.Angle(transform.forward, directionToTarget);

            if (angle <= viewAngle * 0.5f)
            {
                return true;
            }
            return false;
        }
    }
}

