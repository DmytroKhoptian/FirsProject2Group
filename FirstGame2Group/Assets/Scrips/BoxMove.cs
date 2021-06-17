using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    [SerializeField] private float speed;

  
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); 
        
        if(transform.position.y <= -10f)
        {
            transform.position = Vector3.zero;
        }
    }
}
