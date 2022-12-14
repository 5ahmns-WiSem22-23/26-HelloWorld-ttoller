using UnityEngine;

public class HelloVariablen : MonoBehaviour
{
    int myInt = 0;
    bool myBool = true;

    int[] myArray = new int[] { 0, 0, 0 };

    string myString = "myString";
    void Start()
    {
        // Debug.Log(sizeof(int));
        // Debug.Log(sizeof(bool));

        //value type
        int tmp = myInt;
        myInt += 1;
        Debug.Log($"myInt: {myInt} tmp: {tmp}");

        //reference type
        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        foreach (int a in tmpArray)
        {
            Debug.Log(a);
        }

        foreach (int a in myArray)
        {
            Debug.Log(a);
        }


        string tmpString = myString;
        myString = "hello";
        Debug.Log($"myString: {myString} tmpString: {tmpString}");
    }
}
