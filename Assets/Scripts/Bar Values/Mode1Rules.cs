using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode1Rules : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        //1
        if(FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 1;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 1;
            BarValue.chickenActive = 1;
        }


        //2
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 1;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 1;
            BarValue.chickenActive = 1;
        }


        //3
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 1;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 1;
            BarValue.chickenActive = 1;
        }


        //4
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 2;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 2;
            BarValue.chickenActive = 1;
        }


        //5
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 2;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 2;
            BarValue.chickenActive = 1;
        }


        //6
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 2;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 2;
            BarValue.chickenActive = 1;
        }


        //7
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 3;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 3;
            BarValue.chickenActive = 1;
        }


        //8
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 3;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 3;
            BarValue.chickenActive = 1;
        }


        //9
        if (FoodProgress.catFoodPerformance == 1 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 3;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 1 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 3;
            BarValue.chickenActive = 1;
        }


        //10
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 3;
            if(PlayOrder.startWithFood==true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }
            
        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }


        //11
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 2;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 2;
            BarValue.chickenActive = 1;
        }


        //12
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 2;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 1;
            BarValue.chickenActive = 1;
        }


        //13
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 1;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 1;
            BarValue.chickenActive = 1;
        }


        //14
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }


        //15
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //16
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //17
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 3;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 3;
            BarValue.chickenActive = 1;
        }



        //18
        if (FoodProgress.catFoodPerformance == 2 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 3;
            BarValue.catActive = 1;
        }
        if (FoodProgress.chickenFoodPerformance == 2 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 3;
            BarValue.chickenActive = 1;
        }



        //19
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 4;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 4;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //20
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //21
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //22
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 2;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 2;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //23
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 3 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 4;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 3 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 4;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //24
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 3)
        {
            BarValue.catHealth = 4;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 3)
        {
            BarValue.chickenHealth = 4;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //25
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //26
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 2 && ItemProgress.catItemPerformance == 1)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 2 && ItemProgress.chickenItemPerformance == 1)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }



        //27
        if (FoodProgress.catFoodPerformance == 3 && ShelterProgress.catShelterPerformance == 1 && ItemProgress.catItemPerformance == 2)
        {
            BarValue.catHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.catActive = 2;
            }
            else
            {
                BarValue.catActive = 1;
            }

        }
        if (FoodProgress.chickenFoodPerformance == 3 && ShelterProgress.chickenShelterPerformance == 1 && ItemProgress.chickenItemPerformance == 2)
        {
            BarValue.chickenHealth = 3;
            if (PlayOrder.startWithFood == true)
            {
                BarValue.chickenActive = 2;
            }
            else
            {
                BarValue.chickenActive = 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
