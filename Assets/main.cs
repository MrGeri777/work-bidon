using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{

        // этот скрипт накинут на камеру и запускается сразу после генерации камеры в игровом движке

        void Start()
        {
            int count_elem = Random.Range(5, 20); //количество елементов
            int ran_elem;  // тип елемента

            // обьяление существующих елементов
            
            trapeze trapeze_el;
            triangle triangle_el;
            circle circle_el;
            square square_el;


            // Массив обьектов
            ArrayList ms = new ArrayList();

            for (int i = 0; i < count_elem; i++)
            {

                ran_elem = Random.Range(0,3);

                if (ran_elem == 0){ // Если ran_elem 0 то создается трапеция
                    trapeze_el = new trapeze();
                    trapeze_el.get_date();
                    ms.Add(trapeze_el);
                }
                else if(ran_elem == 1){ // Если ran_elem 1 то создается треугольник
                    triangle_el = new triangle();
                    triangle_el.get_date();
                    ms.Add(triangle_el);
                }
                else if(ran_elem == 2){  // Если ran_elem 2 то создается круг
                    circle_el = new circle();
                    circle_el.get_date();
                    ms.Add(circle_el);
                }
                else{    // иначе квадрат
                    square_el = new square();
                    square_el.get_date();
                    ms.Add(square_el);
                }


            }

            // это не работает и лучше его не трогать... Оно здесь для красоты

            // for (int b = 0; b < ms.Count; b++){
            //     Debug.Log("ELEMENT #"+b);
            //     Debug.Log(ms[b].get_date());
            // }
        }
        void Update()
        {
            
        }
}
