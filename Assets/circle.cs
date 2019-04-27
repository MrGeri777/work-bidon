using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle
{

    // обьявление точек, цвета и радиуса

    public List<Point> Points = new List<Point>() {};
    public RGB color = new RGB();

    public int radius;

    public circle(){

        // генерирует круг

        Debug.Log("gen circle");

        // его радиус

        radius = Random.Range(0, 100);

        // цвет

        color.r = Random.Range(0, 255); 
        color.g = Random.Range(0, 255); 
        color.b = Random.Range(0, 255);

    }

    public bool get_date(){

        // выводит в консоль данные об круге

        Debug.Log("squere: "+get_square());
        Debug.Log("Perimeter: "+ get_perimeter());
        Debug.Log("length side: " + get_side()); 
        Debug.Log("Height: " + get_height());
        Debug.Log("color: " + color.r + ":" + color.g + ":"+ color.b);
        return true;
    }

    public float get_height(){

        // высота круга это его диаметр

        return radius*2;
    }

    public float get_perimeter(){

        // возвращает периметр круга

        float p = radius*Mathf.PI*2;
        return p;
    }

    public float get_side(){

        // возвращает периметр круга

        float p = radius*Mathf.PI*2;
        return p;
    }

    public float get_square(){

        // площадь круга

        float S = Mathf.PI*Mathf.Pow(radius, 2);
        return S;
    }
}
