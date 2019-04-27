using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trapeze
{

    // обьявление точек и цвета

    public List<Point> Points = new List<Point>() {};
    public RGB color = new RGB();

    public trapeze()
    {
        Debug.Log("gen trapeze");
        
        int length_1 = Random.Range(0, 200); // длина основания трапеции
        int length_2;
        while (true){   // длина другой основы трапеции (в цикле чтобы случайно не возникло две одинаковых длины оснований)
            length_2 = Random.Range(0, 200);
            if (length_1 != length_2){
                break;
            }
        }
        int height = Random.Range(0, 200); // высота трапеции
        int shift_1 = Random.Range(-100, 100); // сдвиг основания влево или вправо
        int shift_2 = Random.Range(-100, 100); // сдвиг второго основания


        // случайный цвет обьекта
        color.r = Random.Range(0, 255); 
        color.g = Random.Range(0, 255); 
        color.b = Random.Range(0, 255);

        // растановка точек по кругу
        Point origin_gen = new Point();
        origin_gen.x = shift_1; origin_gen.y = (int) height/2;
        Points.Add(origin_gen);

        origin_gen = new Point();
        origin_gen.x = shift_1 + length_1; origin_gen.y = (int) height/2;
        Points.Add(origin_gen);

        origin_gen = new Point();
        origin_gen.x = shift_2 + length_2; origin_gen.y = (int) height/2*-1;
        Points.Add(origin_gen);

        origin_gen = new Point();
        origin_gen.x = shift_2; origin_gen.y = (int) height/2*-1;
        Points.Add(origin_gen);

    }

    public bool get_date(){

        // вывод данных об обьекте в консоль

        Debug.Log("squere: "+get_square());
        Debug.Log("Perimeter: "+ get_perimeter());
        for (int i = 0; i < 4; i++){
            Debug.Log("length side "+i+": "+get_side(i)); 
        }
        Debug.Log("Height: " + get_height());
        Debug.Log("color: " + color.r + ":" + color.g + ":"+ color.b);
        return true;
    }

    public float get_height(){

        // высота трапеции через формулы за точками

        float a = Points[3].length(Points[2]);
        float b = Points[0].length(Points[1]);
        float c = Points[3].length(Points[0]);
        float d = Points[1].length(Points[2]);
        float h = Mathf.Sqrt(Mathf.Pow(c,2) - Mathf.Pow((Mathf.Pow(a-b,2)+Mathf.Pow(c,2)-Mathf.Pow(d,2))/(2*(a-b)),2));
        return h;
    }

    public float get_perimeter(){

        // периметр трапеции

        float p = 0;
        for (int i = 0; i < 4; i++){
            Debug.Log("length side "+i+": "+get_side(i)); 
            p =+ get_side(i);
        }
        return p;
    }

    public float get_side(int side){

        // длина стороны которая задана в int side

        int p1 = side;
        int p2 = ++side;
        return Points[p1%4].length(Points[p2%4]);
    }

    public float get_square(){

        //площадь трапеции 

        float a = Points[3].length(Points[2]);
        float b = Points[0].length(Points[1]);
        float h = get_height();
        float S = (a+b)/2*h;
        return S;
    }
}
