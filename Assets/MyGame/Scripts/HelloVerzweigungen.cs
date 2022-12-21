using UnityEngine;

public class HelloVerzweigungen : MonoBehaviour
{
    void Start()
    {
        int i = 0;
        switch (i)
        {
            case 0:
                Debug.Log("SWITCH: i is 0");
                break;
            case 1:
                Debug.Log("SWITCH: i is 1");
                break;
            default:
                Debug.Log("SWITCH: i is not 0 or 1");
                break;
        }

        if (i == 0)
        {
            Debug.Log("IF: i is 0");
        }
        else if (i == 1)
        {
            Debug.Log("IF: i is 1");
        }
        else
        {
            Debug.Log("IF: i is not 0 or 1");
        }

        string size = i > 5 ? "medium" : "small";
        Debug.Log("TERNARY: i is " + size);

        if (i > 5)
        {
            if (i > 10)
            {
                size = "big";
            }
            else
            {
                size = "medium";
            }
        }
        Debug.Log("IF NEST: i is " + size);


    }
}
