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

        LogBefore(startValue2, "startValue2");
        IncrementValue2ByOne();
        LogAfter(startValue2, "startValue2");

        LogBefore(startValue3, "startValue3");
        IncrementValue3ByX(Random.Range(1, 10));
        LogAfter(startValue3, "startValue3");

        LogBefore(startValue4, "startValue4");
        OutputDecrementedValue(startValue4);
        LogAfter(startValue4, "startValue4");

        LogBefore(startValue5, "startValue5");
        startValue5 = GetDifference(startValue5, 2);
        LogAfter(startValue5, "startValue5");
    }
    private int GetDifference(int first, int second)
    {
        return Mathf.Abs(first - second);
    }

    private void OutputDecrementedValue(int value)
    {
        value--;
        Debug.Log("val: " + value);
    }
    private void IncrementValue3ByX(int x)
    {
        startValue3 += x;
    }
    private void IncrementValue2ByOne()
    {
        startValue2++; // ist das gleiche wie startValue = startValue + 1;
    }
    private void LogBefore(int variable, string name)
    {
        LogWithPrefix("before", $"{name}: {variable}");
    }
    private void LogAfter(int variable, string name)
    {
        LogWithPrefix("after", $"{name}: {variable}");
    }
    private void LogWithPrefix(string prefix, string message)
    {
        Debug.Log($"{prefix} {message}");
    }
}