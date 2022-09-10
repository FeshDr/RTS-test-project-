using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceCOntrol : MonoBehaviour
{
    public Canvas Standart; // стандартный интерфейс его видно всегда
    public Canvas Building; // кнопки для строительства здания
    public Canvas BuildingInterface; // внутренний интерфейс для барака (скорее всего под каждый тип производящего здания будем делать новый)

    // список выделенных предметов selectedList;

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
