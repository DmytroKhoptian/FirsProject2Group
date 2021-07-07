using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls1 = new List<GameObject>();
    [SerializeField] private List<GameObject> balls;

    void Start()
    {
        //balls1.Add(gameObject.transform.GetChild(0).gameObject);

        for (int i = 0; i < transform.childCount; i++)
        {
            balls1.Add(transform.GetChild(i).gameObject);
        }     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
