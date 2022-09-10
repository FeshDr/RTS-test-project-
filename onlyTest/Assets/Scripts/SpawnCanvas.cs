using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void show(Canvas pref)
    {
        Instantiate(pref);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
