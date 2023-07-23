using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkScript : MonoBehaviour
{
    void Start()
    {
        FindDivisors(6,45);
    }

    private void FindDivisors(int numberOne, int numberTwo)
    {
        int[] AllNumbers = {};
        string allItems="All List: ";
        string divisibleByTwo = "Divisible By Two: ";
        string divisibleByThree = "Divisible By Three: ";
        string divisibleByFour = "Divisible By Four: ";
        string divisibleByFive = "Divisible By Five: ";
        for (int i = numberOne; i <=numberTwo; i++)
        {
            allItems+= " - "+ i;
            if (i % 2 == 0)
            {
                divisibleByTwo += " - " + i;
            }
            if (i % 3 == 0)
            {
                divisibleByThree += " - " + i;
            }
            if (i % 4 == 0)
            {
                divisibleByFour += " - " + i;
            }
            if (i % 5 == 0)
            {
                divisibleByFive += " - " + i;
            }
        }
        print(allItems);
        print(divisibleByTwo);
        print(divisibleByThree);
        print(divisibleByFour);
        print(divisibleByFive);


    }
    
}
