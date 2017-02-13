using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {


    public bool myBool;
    public string myString = "Cat";
    public int num1;
    public int num2;
    public int num3;
    public int num4;
    public string myString = "Roses"

	// Use this for initialization
	void Start () {
	    if (myBool)
        {
            print(true);
        }

        if(myString == "Cat") //== is a comparison tool. It's essential in conditionals.
        {
            print("Cat");
        }

        if(!myBool)
        {
            print(false);
        }

        if(myString != "Cat") //!= means "does not equal"
        {
            print(myString);
        }

        if(num1 + num2 == 7)
        {
            print(7);
        }

        if (num1 + num2 != 7)
        {
            print(num1 + num2); // meaning, print the true solution based on the two inputs
        }

        if  (num2/num4 == 6)
        {
            print(6);
        }

        if (num4/num3 == 12)
        {
            print(12);
        }

        if (num4 + num3 != 25)
        {
            print(num4 + num3);
        }

        if(myString == "tulips")
        {
            print("not roses") //print statements can be essentially whatever you want them to be
        }

	}
	
}
