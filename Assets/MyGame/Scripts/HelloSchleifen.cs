using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    [SerializeField]
    private int[][] myArray = { new int[] { 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8, 9 } };
    private void Start()
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
            {
                Debug.Log($"i {i}, j {j} = {myArray[i][j]}");
            }
        }
    }
}
