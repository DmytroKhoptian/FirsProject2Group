using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFunck : MonoBehaviour
{
    private float[] prices = new float[3];
    private string[,] houses = new string[3, 5];

    void Start()
    {
        houses = new string[,]
        {
            { "�������", "5", "10", "5000"}, //0
            { "������", "5", "10", "1000" }, //1
            { "�������", "91", "60", "3000"} //2
        };

        print(houses[0, 1]);
        PrintWelcome();
        Divide(5f, 2f);

        prices[0] = CostSquere(CountSquere(float.Parse(houses[0, 1]), float.Parse(houses[0, 2])), float.Parse(houses[0, 3]));
        prices[1] = CostSquere(CountSquere(10f, 5f), 555555f);
        prices[2] = CostSquere(CountSquere(18f, 2f), 987654f);
    }


    private float CountSquere(float width, float height) // ���������
    {
        float rez = width * height / 100;
        return rez;
    }
    private float CostSquere(float squere, float price) // ���������
    {
        float rez = squere * price / 100;
        return rez;
    }


    private void CheckAge(string name, int age)
    {
        if(age >= 18)
        {
            print("��������");
        }
        else
        {
            print("��������");
            print("�����" + (18-age));
        }
    }









    private void PrintWelcome()
    {
        print("������");
        print("����� ����������");
    }

    private void Divide(float num1, float num2) // ���������
    {
        float rez = num1 / num2;
        print(rez);
    }

    private void Divide(int num1, int num2) // ���������
    {
        float rez = num1 / num2;
        print(rez);
    }

}
