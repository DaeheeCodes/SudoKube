using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMap : MonoBehaviour
{
    private CubeState cubeState;

    public Transform up;
    public Transform down;
    public Transform left;
    public Transform right;
    public Transform front;
    public Transform back;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Set()
    {
        cubeState = FindObjectOfType<CubeState>();

        UpdateMap(cubeState.front, front);
        UpdateMap(cubeState.back, back);
        UpdateMap(cubeState.left, left);
        UpdateMap(cubeState.right, right);
        UpdateMap(cubeState.up, up);
        UpdateMap(cubeState.down, down);
    }


    void UpdateMap(List<GameObject> face, Transform side)
    {
        int i = 0;
        print(face[0].name[1]);
        foreach (Transform map in side)
        {
            if (face[i].name[1] == '1')
            {
                map.GetComponent<Text>().text = "1";
            }
            if (face[i].name[1] == '2')
            {
                map.GetComponent<Text>().text = "2";
            }
            if (face[i].name[1] == '3')
            {
                map.GetComponent<Text>().text = "3";
            }
            if (face[i].name[1] == '4')
            {
                map.GetComponent<Text>().text = "4";
            }
            if (face[i].name[1] == '5')
            {
                map.GetComponent<Text>().text = "5";
            }
            if (face[i].name[1] == '6')
            {
                map.GetComponent<Text>().text = "6";
            }
            if (face[i].name[1] == '7')
            {
                map.GetComponent<Text>().text = "7";
            }
            if (face[i].name[1] == '8')
            {
                map.GetComponent<Text>().text = "8";
            }
            if (face[i].name[1] == '9')
            {
                map.GetComponent<Text>().text = "9";
            }
            i++;
        }
    }
}
