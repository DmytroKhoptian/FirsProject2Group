using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public string cityName; // �������� ��������� ����������
    private float cityPopulation = 486000f; // �������� ��������� ���������� � ����������������
    [SerializeField] private int cityYearOfCreate;
    [SerializeField] private float citySquare;
    private float thickness;
    private int regionPopulation = 1190000;
    int cityAge;

    [SerializeField] private bool isContactWithSea = true;

    [Range(0f, 100f)][SerializeField] private float partOfUcrainian;


    [SerializeField] private Vector2 position = new Vector2(10.02f, 150.74f);


    void Start()
    {
        print(position);
        print("X: " + position.x + "Y: " +position.y);

        cityAge = 2021 - cityYearOfCreate;
        print("������" + cityAge + "���");

        thickness = citySquare / cityPopulation;

        Debug.Log("���������� � ������ " + cityName);
        Debug.LogError("��� ��������� " + cityYearOfCreate);
        print("������� ���������: " + thickness + "���/��.�");
    }
    
}
