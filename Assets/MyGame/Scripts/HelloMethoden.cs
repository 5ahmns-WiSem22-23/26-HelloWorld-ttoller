using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    // Instanzvariable nutzen
    private int startValue2 = 0;

    //der Wert der zugezählt wird ist bei Deklaration noch nicht bekannt
    // z.B: Random oder User Input
    private int startValue3 = 0;

    // Copy By Value
    private int startValue4 = 10;

    private int startValue5 = 20;
    void Start()
    {
        // Verwende Start Methode
        Debug.Log("Hello Methoden!");

        Debug.Log("before startValue: " + startValue2);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue2);

        Debug.Log("before startValue3: " + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after startValue3: " + startValue3);

        Debug.Log("before startValue4: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4: " + startValue4);

        Debug.Log("before startValue5: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after startValue5: " + startValue5);
    }
    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }
    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }
    private void IncrementByOne()
    {
        startValue2++; // ist das gleiche wie startValue = startValue + 1;
    }
}
