using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    [SerializeField] private int[] freeDays;
    //                                          0       1        2
    private string[] sumMon = new string[3] { "����", "����", "A�����" };

    private string[] month = new string[12];

    private string[] films = new string[6] { "���", "����", "���", "��������", "����� ���", ""};
    private string filmsLine = "";



    void Start()
    {
        month[0] = "afafzx";


        films[6] = "����";
        print("C�����" + sumMon[0]);
        print("��������" + freeDays[0] + freeDays[1] + freeDays[2]);
        print("--------------------------------------------------");

        foreach (string film in films)
        {
            if (film == films[films.Length - 1])
            {
                filmsLine += film + " !!!!";
            }
            else
            {
                filmsLine += film + ", ";
            }
        }
        print(filmsLine);





        PrintArray(films);
    }

    private void PrintArray(string[] array)
    {
        foreach (string film in array)
        {
            print(film);
        }
    }
}






  //for(int i = 0; i < films.Length; i++)
        //{
        //    print(films[i]);
        //}