using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceCOntrol : MonoBehaviour
{
    public Canvas Standart; // ����������� ��������� ��� ����� ������
    public Canvas Building; // ������ ��� ������������� ������
    public Canvas BuildingInterface; // ���������� ��������� ��� ������ (������ ����� ��� ������ ��� ������������� ������ ����� ������ �����)

    // ������ ���������� ��������� selectedList;

    private Canvas activeCanvas = null;

    private void Start()
    {

    }

    public void changeCanvas()
    {

        activeCanvas = Building;
    }

    public void closeCanvas()
    {
        Building.enabled = false;
        BuildingInterface.enabled = false;
        activeCanvas = null;
    }

    private void Update()
    {
        
    }
}
