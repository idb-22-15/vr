using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatheScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isLatheEnabled = false;
    public GameObject cubePrefab;
    private Stack<GameObject> cubes = new Stack<GameObject>();

    public void onToggle()
    {
        if (!isLatheEnabled) CreateCube();
        else DestroyCube();
        isLatheEnabled = !isLatheEnabled;

    }

    private void CreateCube()
    {
        Console.WriteLine("AAAA");
        Transform pos = cubePrefab.transform;
        GameObject newCube = Instantiate(cubePrefab, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
        cubes.Push(newCube);
    }
    private void DestroyCube()
    {
        Destroy(cubes.Pop());
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
