
using UnityEngine;

public class practice3 : MonoBehaviour
{
    public GameObject cube;
    private void Start()
    {
        CreateFloor(10);
    }
    private void CreateFloor(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                print("i=" + i);
                for (int j = 1; j <= i; j++)
                {
                    Instantiate(cube, new Vector3(i * 2, j * 2 , 0), Quaternion.Euler(270, 0, 0));
                print("j=" + j);
                }
            }
        }
}
