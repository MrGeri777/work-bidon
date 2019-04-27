using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square
{

    // обьявление точек и цвета

    public List<Point> Points = new List<Point>() {};
    public RGB color = new RGB();

    public square(){
        Debug.Log("gen square");

        // случайная длина стороны квадрата
        
        int length = Random.Range(0, 200);

        // цвет

        color.r = Random.Range(0, 255); 
        color.g = Random.Range(0, 255); 
        color.b = Random.Range(0, 255);
        
        // растановка точек квадрата на равное отдаление от центра

        Point origin_gen = new Point();
        origin_gen.x = (int) -length/2; origin_gen.y = (int) length/2;
        Points.Add(origin_gen);

        origin_gen = new Point();
        origin_gen.x = (int) length/2; origin_gen.y = (int) length/2;
        Points.Add(origin_gen);

        origin_gen = new Point();
        origin_gen.x = (int) length/2; origin_gen.y = (int) -length/2;
        Points.Add(origin_gen);

        origin_gen = new Point();
        origin_gen.x = (int) -length/2; origin_gen.y = (int) -length/2;
        Points.Add(origin_gen);
    }

    public bool get_date(){

        // выводит в консоль данные об квадрате

        Debug.Log("squere: "+get_square());
        Debug.Log("Perimeter: "+ get_perimeter());
        Debug.Log("length side: " + get_side()); 
        Debug.Log("Height: " + get_height());
        Debug.Log("color: " + color.r + ":" + color.g + ":"+ color.b);
        return true;
    }

    public float get_height(){

        // высота квадрата это одна из его сторон

        float h = Points[0].length(Points[1]);
        return h;
    }

    public float get_perimeter(){

        // периметр это одна из сторон *4

        float p = Points[0].length(Points[1]) * 4;
        return p;
    }

    public float get_side(){

        // длина любой из сторон
        
        float s = Points[0].length(Points[1]);
        return s;
    }

    public float get_square(){

        // площадь квадрата

        float S = Mathf.Pow(Points[0].length(Points[1]), 2);
        return S;
    }
}
