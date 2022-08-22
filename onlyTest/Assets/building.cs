using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour
{
    public int weight;
    public int height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDrawGizmos()
    {
        for(int x = 0;x < weight; x++)
        {
            for(int y = 0; y < height; y++)
            {
                if (y % 2 == x % 2)
                {
                    Gizmos.color = new Color(1f,0f,.5f,0.2f);
                } else
                {
                    Gizmos.color = new Color(.5f, 0f, 1f, 0.2f); ;
                }
                Gizmos.DrawCube(transform.position + new Vector3(x*10,0,y*10), new Vector3(10,.1f,10));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
