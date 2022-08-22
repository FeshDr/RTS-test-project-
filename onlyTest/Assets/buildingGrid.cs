using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingGrid : MonoBehaviour
{
    private int weight = 10;
    private int height = 10;
    private Camera mainCamera;

    public building[,] grid;
    building flyBuilding;
    // Start is called before the first frame update
    void Start()
    {
        grid = new building[weight, height];

        mainCamera = Camera.main;
    }

    public void startPlacingBuilding(building buildingPrefab)
    {
        if (flyBuilding != null)
        {
            Destroy(flyBuilding.gameObject);
        }

        flyBuilding = Instantiate(buildingPrefab);
    }
    // Update is called once per frame
    void Update()
    {
        if(flyBuilding != null)
        {
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if(groundPlane.Raycast(ray,out float position))
            {
                Vector3 worldPosition = ray.GetPoint(position);

                int x = Mathf.RoundToInt(worldPosition.x / 10);
                float y = Mathf.RoundToInt(worldPosition.z / 10);

                flyBuilding.transform.position = new Vector3(x, 0 , y) * 10 + new Vector3(10,0,10) * .5f;

                if (Input.GetMouseButtonDown(0))
                {
                    flyBuilding = null;
                }
            }
        }
    }
}
