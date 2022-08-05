using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    string heroname = "saleh";
    int heropower = 40;
    string villanName = "othman";
    int villanpower = 10;
    // Start is called before the first frame update

    float playerspeed = 15;

    void Start()
    {
        if (heropower > villanpower)
        {
            print(heroname + "as always stronger");

        }
        else if (heropower == villanpower)
        {
            print(heroname + "eqauls" + villanName);
        }
        else
        {
            print(villanName + "is mysteriously stronger");

            //the villan is my twin
        }

        SetSpeed(2.5f);

        




    }

    void SetSpeed(float speed)
    {
        print(playerspeed);
        playerspeed = speed;
        print(playerspeed);
    }



    }

