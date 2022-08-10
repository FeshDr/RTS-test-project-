using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTest : MonoBehaviour
{

    public GameObject prefab1;
    private GameObject ModPrefab;

    // Start is called before the first frame update
    void Start()
    {

            StartCoroutine("delay");

    }

     public void Do()
    {
        StartCoroutine("delay");
    }

    IEnumerator delay()
    {
        for (int i = 0; i < 10; i++)
        {
            
            //Debug.Log(i + " step");
            if (GameObject.FindWithTag("Finish"))
            {
                ModPrefab = prefab1.GetComponent<UnitClassSword>().training = GameObject.FindWithTag("Finish");
            }
            else Debug.Log("Finish tag not found");
            
            Instantiate(prefab1, new Vector3(0, 2 * i, 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
