using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public float speed;
    private RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Debug.Log("Left btn push");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 50000.0f))
            {

                Debug.Log(hit.point);

                Vector3 distant = hit.point - transform.position;

                float len = distant.magnitude; // находим длинну

               
                if (distant.magnitude >= 1)
                {
                    for(int i = 0; i < 10; i++)
                    transform.Translate(distant / len * speed * Time.deltaTime);
                }
            }

        }
    }

    private void move()
    {

    }
}
