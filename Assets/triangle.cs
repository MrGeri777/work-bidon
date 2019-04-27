using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle
{

    // обьявление точек и цвета

    public List<Point> Points = new List<Point>() {};
    public RGB color = new RGB();

    public triangle(){

        //генерация треугольника

        Debug.Log("gen Triangle");

        int x = 0; int y = 0;


        // обьявление точки
        Point origin_gen;
        
        // рандомный цвет

        color.r = Random.Range(0, 255); 
        color.g = Random.Range(0, 255); 
        color.b = Random.Range(0, 255);


            // генерация трёх случайных точек
        for (int i = 0; i < 3; i++)
        {
            
            x = Random.Range(-100, 100);
            y = Random.Range(-100, 100);
            origin_gen = new Point();
            origin_gen.x = x; origin_gen.y = y;
            Points.Add(origin_gen);
        }
    }

    public bool get_date(){

        // вывод данных об треугольнике в консоль

        Debug.Log("squere:"+get_square());
        Debug.Log("Perimeter: "+ get_perimeter());
        for (int i = 0; i < 3; i++){
            Debug.Log("length side "+i+": "+get_side(i)); 
        }
        for (int i = 0; i < 3; i++){
            Debug.Log("Height from vertex #"+i+": "+get_height(i));
        }
        Debug.Log("color: " + color.r + ":" + color.g + ":"+ color.b);
        return true;
    }

    public float get_perimeter(){

        // периметр треугольника

        float p = 0;
        for (int i = 0; i < 4; i++){
            Debug.Log("length side "+i+": "+get_side(i)); 
            p =+ get_side(i);
        }
        return p;
    }

    public float get_square(){

        // площадь треугольника

        float p = (Points[0].length(Points[1]) + Points[0].length(Points[2]) + Points[1].length(Points[2])) / 2;
        float S =  Mathf.Sqrt(p*(p - Points[0].length(Points[1]))*(p - Points[0].length(Points[2]))*(p - Points[1].length(Points[2])));
        return S;
    }
    public float get_side(int side){
        
        // длина стороны которая задана в int side

        int p1 = side;
        int p2 = ++side;
        return Points[p1%3].length(Points[p2%3]);
    }
    public float get_height(int vertex){

        // высота треугольника точке INT vertex

        float p = (Points[0].length(Points[1]) + Points[0].length(Points[2]) + Points[1].length(Points[2])) / 2;
        float h = 2/Points[(vertex+1)%3].length(Points[(vertex+2)%3])*Mathf.Sqrt(p*(p-Points[(vertex+1)%3].length(Points[(vertex+2)%3]))*(p-Points[(vertex)%3].length(Points[(vertex+1)%3]))*Points[(vertex+2)%3].length(Points[(vertex+3)%3]));
        return h;
    }
}
