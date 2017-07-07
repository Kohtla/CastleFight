using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicMap{

    private bool[,] data;    

    public bool[,] Map
    {
        get
        {
            return data;
        }

        set
        {
            data = value;
        }
    }

    public LogicMap(int x, int z)
    {
        Map = new bool[x, z];
    }

    public void TakePosition(int xos, int zos)
    {
        Map[xos, zos] = true;

    }//Метод ставит true в массив

    public void FreePosition(int xos, int zos)
    {
        Map[xos, zos] = false;

    }//Метод ставит false в массив    
}
