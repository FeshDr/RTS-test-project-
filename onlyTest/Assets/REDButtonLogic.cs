using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class REDButtonLogic : MonoBehaviour
{
    public Button RED;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = RED.GetComponent<Button>();
        btn.onClick.AddListener(Task);
    }


    void Task()
    {

        obj.GetComponent<SpawnTest>().Do();
        
    }
    // Update is called once per frame

}
