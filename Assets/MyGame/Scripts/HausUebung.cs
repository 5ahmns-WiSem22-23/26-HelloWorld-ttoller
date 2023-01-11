using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HausUebung : MonoBehaviour
{
    [SerializeField]
    private char[,] myArray = new char[3, 4];

    private void Start()
    {
        int characterIndex = 65;
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[i, j] = (char)characterIndex;
                Debug.Log($"i {i}, j {j} = {myArray[i, j]}");
                characterIndex++;
            }
        }
    }
}
