using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
     
    void Start()
    {

        int j = 10;

        while (j >= 0)
        {
            j--;
        }

        int k = -10;

        while (k <= 10)
        {
            k++;
            print(k);
        }


        int wasted = 0;
        int price = 60;
        int age = 25;

        while(age < 80)
        {
            print("��� " + age);
            age++;

            if((age > 30) && (age < 40))
            {
                print("�� ����");
                continue;
            }
            else if(age == 60)
            {
                print("����...");
                break;
            }
            print("����");
            wasted += 15 * 12 * price;
          
        }


        print("���������" + wasted);







        //for(int i = 0; i < 2000; i = i + (i * 3))
        // {
        //     print(i);

        // }

        //int i = 1;
        //int j = 0;
        //while (i < 70000)
        //{
        //    i = i + (i * 3);
        //    Debug.Log(i);
        //    j++;
            
        //}
        //print("����� ����" + j);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
