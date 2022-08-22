using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid
{
    private int width;
    private int hight;
    private float cellsize;
    private int[,] gridArray;
    private TextMesh[,] debugTextArray;

    public Grid (int width, int hight, float cellsize)
    {
        this.width = width;
        this.hight = hight;
        this.cellsize = cellsize;

        gridArray = new int[width, hight];
        debugTextArray = new TextMesh[width, hight];

        for (int x= 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                gridArray[x, y] = 0;
                debugTextArray[x, y] = AUtils.CreateWorldText(gridArray[x,y].ToString() , null ,GetWorlPosition(x,y) + new Vector3(cellsize, 0 , cellsize) * .5f, 20 ,Color.yellow, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorlPosition(x,y),GetWorlPosition(x,y+1), Color.yellow, 100f);
                Debug.DrawLine(GetWorlPosition(x,y), GetWorlPosition(x + 1, y), Color.yellow, 100f);
            }
        }

        Debug.DrawLine(GetWorlPosition(gridArray.GetLength(0), 0), GetWorlPosition(gridArray.GetLength(0), gridArray.GetLength(1)), Color.yellow, 100f);
        Debug.DrawLine(GetWorlPosition(0, gridArray.GetLength(1)), GetWorlPosition(gridArray.GetLength(0), gridArray.GetLength(1)), Color.yellow, 100f);

    }

    private Vector3 GetWorlPosition(int x, int y)
    {
        return new Vector3(x, 0, y) * cellsize;
    }

    public int getValue(int x, int y)
    {
        return gridArray[x, y];
    }

    public void setValue(int x, int y, int value)
    {
        if (x > 0 && y > 0 && x < gridArray.GetLength(0) && y < gridArray.GetLength(1))
        {
            gridArray[x, y] = value;
            debugTextArray[x, y].text = value.ToString();
        }
    }


}
