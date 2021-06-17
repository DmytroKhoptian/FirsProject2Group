using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    //if(условие)
    //{
    //инструкции;
    //}
    int a = 5;
    int b = 15;
    int rez;

    void Start()
    {
        rez = a + b + a;
        print(rez + " m");
    }
}
        //int a = 5;
        //int b = 10;
        //if (a > b)   //     >  <  >=  <=  ==  !=
        //{
        //    print(a + "больше" + b);
        //}
        //else
        //{
        //    print(b + "больше" + a);
        //}

        //string pas1 = "qwerty";

        //if (pas1 == "qwerty")
        //{
        //    print("Correct");
        //}
        //else
        //{
        //    print("UnCorrect");
        //}


        //string user = "вася";

        //switch (user)
        //{
        //    case "admin":
        //        print("Все права");
        //        break;
        //    case "student":
        //        print("Права ограничены");
        //        break;
        //    default:
        //        print("Доступ запрещен");
        //        break;
        //}



        //if(t > 100f)
        //{
        //    print("пар");
        //}
        //else if (t > 0f)
        //{
        //    print("вода");
        //}
        //else
        //{
        //    print("лед");
        //}
        //if (t > 100f)
        //{
        //    print("пар");
        //}
        //if ((t > 0f) && (t < 100f))      // && - и  || - или
        //{
        //    print("вода");
        //}
        //if (t < 0f)
        //{
        //    print("лед");
        //}





