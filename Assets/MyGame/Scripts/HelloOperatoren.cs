using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    int a = 3;
    int b = 5;
    void Start()
    {
        //switch the values of a and b

        Debug.Log("Before operations: a is " + a + ", b is " + b);
        Debug.Log("Add negative b to a: " + (a + (-b)));
        Debug.Log("Create a statement if b minus two is not a: " + ((b - 2 != a)));
        Debug.Log("Negate that statement twice: " + (!!(b - 2 != a)));
        Debug.Log("Create another statement if a plus two is not b: " + (a + 2 != b));
        Debug.Log("Create another statement if b plus 5 is equal to two: " + (b + 5 == 2));
        Debug.Log("If the statement and the second is true or the third one is true, add a, if it's false add b: " + (a + (-b) + ((!!(b - 2 != a) && a + 2 != b || b + 5 == 2) ? a : b)));
        b = a + (-b) + ((!!(b - 2 != a) && a + 2 != b || b + 5 == 2) ? a : b);
        a = ((b % (b - 1)) + 1) * 2 + 1;

        Debug.Log("After operations: a is " + a + ", b is " + b);
    }
}
