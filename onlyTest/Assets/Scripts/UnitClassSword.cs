using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitClassSword : UnitClass
{
    public GameObject training;
    public float speed;

    new
    // Start is called before the first frame update
    void Start()
    {



    }

    new
    // Update is called once per frame
    void Update()
    {
        Vector3 distant = training.transform.position - transform.position;

        float len = distant.magnitude; // находим длинну

        float time = len / speed;

        if (distant.magnitude  >= 1)
        {
            transform.Translate(distant / len * speed * Time.deltaTime);
        }

    }


}
