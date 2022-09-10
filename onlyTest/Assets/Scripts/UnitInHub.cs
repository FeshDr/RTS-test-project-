using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitInHub : MonoBehaviour
{
    public GameObject unitView2;
    public Button UnitView;
    public Canvas Test;

    private Button[] units;
    // Start is called before the first frame update
    void Start()
    {
        units = new Button[10];

        for(int i = 1; i < 10; i++)
        {
            units[i] = Instantiate(UnitView, Test.transform);
            units[i].GetComponent<Image>().color = new Color(100,0,0, 0.1f * i);

            units[i].transform.Translate(new Vector3(i * 35f,-20f,0));
        }
    }

    public void fillHub(List<Transform> SelectedUnits)
    {
        for(int i = 0; i < SelectedUnits.Count; i++)
        {
            // пожно сделать проверку на количество хп и менять цвет иконки;
            units[i] = Instantiate(UnitView, Test.transform);
            units[i].transform.Translate(new Vector3(i * 35f, -20f, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
