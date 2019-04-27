using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point 
{

    // структура для точки (Использовал вместо встроеного метода т.к. в начале написания этого проекта не имел представление об существование и то как работает встроенный в юнити тип данных для точек)

    public int x, y;
    public float length(Point pt){

        // метод возвращает длину между точками
        return Mathf.Sqrt(Mathf.Pow(pt.x - x, 2.0f) + Mathf.Pow(pt.y - y, 2.0f));
    }
}