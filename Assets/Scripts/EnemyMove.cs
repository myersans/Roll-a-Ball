using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
       transform.Translate(new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime); 
    }
}