using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Session2_Homework_Dog_Class
{
    class Dog
    {
        //Variables
        string breed;
        string name;
        string sex;
        string size;
        string eyeColor;
        string hairColor;

        int age;
        float height;
        float weight;
        
        bool adult;
        bool healthy;

        //Constructor
        public Dog(string _name, string _breed, string _sex, int _age, float _weight)

        {
            name = _name;
            breed = _breed;
            sex = _sex;
            age = _age;
            weight = _weight;
        }

        //Behavious(Functions)
        public string GetName()
        {
            return name;
        }
        public string GetBreed()
        {
            return breed;
        }
        public string GetSex()
        {
            return sex;
        }       
        public int GetAge()
        {
            return age;
        }
        public float GetWeight()
        {
            return weight;
        }
        public void SetEyeColor(string _eyeColor)
        {
            eyeColor = _eyeColor;
        }
        public void SetHairColor(string _hairColor)
        {
            hairColor = _hairColor;
        }
        public void Running()
        {
            Debug.Log("at lightning speed");
        }
        public void Walking()
        {
            Debug.Log("with its head held high");
        }
        public void Eating()
        {
            Debug.Log("making a dreadful mess");
        }
        public void Playing()
        {
            Debug.Log("always Wagging the tail");
        }
        public void Sleeping()
        {
            Debug.Log("snoring occasionally");
        }
    }
}
