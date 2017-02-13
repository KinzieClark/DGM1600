using UnityEngine;
using System.Collections;

public class ElseStatements : MonoBehaviour {

    public bool myBool;
    public string myString = "Cat";
    public int num1;
    public int num2;
    public int num3;
    public int num4;
    public string myString2 = "Roses"

	// Used my previous if statements to create these else statements.
	void Start () {
	    if (myBool)
        {
            print(true);
        else
            print(false);
        }

        if(myString == "Cat")
        {
            print("Cat");
        else
            print("Not Cat")
        }

        if(!myBool)
        {
            print(false);
        else
            print(true);
        }

        if(myString != "Cat")
        {
            print(myString);
        else
            print(Not myString)
        }

        if(num1 + num2 == 7)
        {
            print(7);
        else
            print(num1 + num2);
        }

        if (num1 + num2 != 7)
        {
            print(num1 + num2);
        else
            print(num1+num2);
        }

        if  (num2/num4 == 6)
        {
            print(6);
        else
            print("num2/numb4 is not 6");
        }

        if (num4/num3 == 12)
        {
            print(12);
        else
            print(num4/num3);
        }

        if (num4 + num3 != 25)
        {
            print(num4 + num3);
        else
            print(true)
        }

        if(myString2 == "tulips")
        {
            print("not roses")
        else
            print("Roses")
        }

	}
	
}