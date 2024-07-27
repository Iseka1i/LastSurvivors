using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITargeting : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Trigggggger: " + collision.gameObject);
        if (collision.gameObject.GetComponent<AI.AIStatsInfo>() == true)
        {
            Debug.Log("Targeting");
        }
    }
}
