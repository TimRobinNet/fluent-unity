using System.Runtime.InteropServices;
using UnityEngine;

public class RunTest : MonoBehaviour
{
    [DllImport("libfluent_unity")]
    private static extern int double_input(int x);

    [DllImport("libfluent_unity")]
    private static extern int triple_input(int x);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(double_input(14));
        Debug.Log(triple_input(14));
    }
}
