using UnityEngine;
using System.Collections;

public class MathOperators : MonoBehaviour {

    public int addition = 12 + 4;
    public int subraction = 12 - 4;
    public float division = 5.0f / 2.0f;
    public int multiplication = 10 * 2;
    public int remainder = 7 % 2;

	// Use this for initialization
	void Start () {
        addition += 9; //+= means "add to" an already existing sum.
        subraction -= 10; //-= means "subrtract from" an already existing sum.
        addition += 3;
        addition = 1;
	}
}
