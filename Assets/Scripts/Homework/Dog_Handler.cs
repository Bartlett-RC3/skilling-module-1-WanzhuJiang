using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Session2_Homework_Dog_Class;

public class Dog_Handler: MonoBehaviour
{
    //Variables
    Dog Jess, Leslie, Sirius;

    // Start is called before the first frame update
    void Start()
    {
        Jess = new Dog("Jess", "Beagle", "male", 5, 10.5f);
        Leslie = new Dog("Leslie", "Bichon Frise", "female", 3, 4.5f);
        Sirius = new Dog("Sirius", "German Shepherd", "male", 10, 22.8f);

        Debug.Log(Jess.GetName() + " is a " + Jess.GetAge() + "-year-old " + Jess.GetSex() + " dog.");
        Debug.Log(Leslie.GetName() + " and " + Sirius.GetName() + " are good friends.");
        Leslie.Playing();
        Sirius.Sleeping();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

