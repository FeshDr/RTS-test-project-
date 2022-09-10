using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection_component : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        if (GetComponent<Barrac>())
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        } 
        else
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }

    private void OnDestroy()
    {

        if (GetComponent<UnitClass>())
        {
            Debug.Log("Свой");
            GetComponent<Renderer>().material.color = Color.blue;

        }
        else if (GetComponent<EnemyClass>())
        {
            Debug.Log("Чужой");
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (GetComponent<Barrac>())
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
    }
}