using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public Transform playerUnits;
    public Transform enemyUnits;

    private void Start()
    {
        instance = this;
        Debug.Log("Work");
        UnitHandler.instance.SetBasicUnitStats(playerUnits);
        UnitHandler.instance.SetBasicUnitStats(enemyUnits);
    }

    void Update()
    {
        UnitHandler.instance.SetBasicUnitStats(playerUnits);
        UnitHandler.instance.SetBasicUnitStats(enemyUnits);
        InputHandler.instance.HandleUnitMovement();
    }
}
