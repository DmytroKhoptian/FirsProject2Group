using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    [SerializeField] private int[] freeDays;
    //                                          0       1        2
    private string[] sumMon = new string[3] {"����", "����", "A�����"};

    void Start()
    {
        print("C�����" + sumMon[0]);
        print("��������" + freeDays[0] + freeDays[1] + freeDays[2]);
    }

    
    void Update()
    {
        
    }
}
