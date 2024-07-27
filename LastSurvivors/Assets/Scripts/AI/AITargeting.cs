using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITargeting : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Trigggggger: " + collision.gameObject);
        if (collision.gameObject.GetComponent<Player.MoveController>() == true)
        {
            Debug.Log("Targeting");
        }
    }
}
