using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2Homework : MonoBehaviour
{
    // Characters Array
    string[] characters = { "Harry", "Ron", "Hermione", "Neville", "Luna" };

    // Start is called before the first frame update
    void Start()
    {       
        //For loop
        for (int i = 0; i < characters.Length; i++)
        {
            Debug.Log("The NO."+i+ " character is "+ characters[i]);
        }
        
        // A function that uses a condition
        int scoreOfPotions = 92;
        int scoreOfCharms = 100;
        int scoreOfTransfiguration = 85;

        if (scoreOfPotions >= 60 && scoreOfCharms >= 60 && scoreOfTransfiguration >= 60)
        {
            Debug.Log("Congratulations! You have passed Nastily Exhausting Wizarding Test!");
            if (scoreOfPotions >= 90 && scoreOfCharms >= 90 && scoreOfTransfiguration >= 90)
            {
                Debug.Log("Your final level is O(Outstanding).");
                if (scoreOfPotions == 100 && scoreOfCharms == 100 && scoreOfTransfiguration == 100)
                    Debug.Log("You are really an all-around winner!!!)");
            }                
            else if (scoreOfPotions >= 75 && scoreOfCharms >= 75 && scoreOfTransfiguration >= 75)
                Debug.Log("Your final level is E(Exceeds Expectations).");
            else 
                Debug.Log("Your final level is A(Acceptable).");
        }
        else
        {
            Debug.Log("Sorry, please try again next year!");
            if (scoreOfPotions <= 30 && scoreOfCharms <= 30 && scoreOfTransfiguration <= 30)
                Debug.Log("Your final level is T(Troll).");
            else if(scoreOfPotions <= 45 && scoreOfCharms <= 45 && scoreOfTransfiguration <= 45)
                Debug.Log("Your final level is D(Dreadful).");
            else
                Debug.Log("Your final level is P(Poor).");
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
