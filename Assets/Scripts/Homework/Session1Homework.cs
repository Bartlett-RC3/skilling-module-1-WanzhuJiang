using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {
    private string FirstName = "Wanzhu";
    private string FamilyName = "Jiang";
    private int StudentNumber = 20147073;

    //Variables 
    public string NameOfThisMagicObject = "Philosopher's Stone";
    public string OwnerOfThisMagicObject = "Nicolas Flamel";
    public int AgeOfThisMagicObject = 665;
    public int EnergyOfThisMagicObject = 10000;
    public float SpeedOfTheMagicObject = 341.07f;
    public bool EmergeInTheMirrorOfErised = true;

    //Data Structures
    public int[] GringottsBankPassword = new int[3];
    public float[] UseTime = { 12.25f, 1.10f, 2.02f };
    public List<string> UserName = new List<string>();

    //Function
    public int CalculatorProduct(int _FirstNumber, int _SecondNumber)
    {
        int ProductResult = _FirstNumber * _SecondNumber;
        return ProductResult;
    }
    public int CalculatorSum(int _FirstNumber, int _SecondNumber, int _ThirdNumber)
    {
        int SumResult = _FirstNumber + _SecondNumber + _ThirdNumber;
        return SumResult;
    }

    // Use this for initialization
    void Start() {

        //Print of the Variables
        Debug.Log("The secret of this magic object is hidden in this script");
        Debug.Log(NameOfThisMagicObject + " is own to " + OwnerOfThisMagicObject);
        Debug.Log(NameOfThisMagicObject + " and " + OwnerOfThisMagicObject + " are both " + AgeOfThisMagicObject.ToString() + " years old");
        
        //Print of the Calculation
        int PowerOfThisMagicObject = CalculatorProduct(AgeOfThisMagicObject, EnergyOfThisMagicObject);
        Debug.Log(NameOfThisMagicObject + " has great power of " + PowerOfThisMagicObject.ToString() + "KJ");
        
        //Add Data to the Array
        GringottsBankPassword[0] = 731;
        GringottsBankPassword[1] = 301;
        GringottsBankPassword[2] = 919;
        int FinalPassword = CalculatorSum(GringottsBankPassword[0], GringottsBankPassword[1], GringottsBankPassword[2]);
        Debug.Log("FinalPassword:"+ FinalPassword.ToString());
       
        //Add Data to the List
        UserName.Add("Harry Potter");
        Debug.Log("The last user is "+UserName[0]);

        //Create a Dictionary
        var Characters = new Dictionary<string, string>();
        Characters.Add("Gryffindor", "Harry Potter,Ronald Weasley,Hermione Granger");
        Characters.Add("Hufflepuff", "Cedric Diggory,Nymphadora Tonks,Hannah Abbott");
        Characters.Add("Ravenclaw", "Luna Lovegood,Cho Chang,Padma Patil");
        Characters.Add("Slytherin", "Draco Malfoy,Pansy Parkinson,Severus Snape");
        Debug.Log(Characters["Gryffindor"]);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
