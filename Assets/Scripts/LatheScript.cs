using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatheScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isLatheEnabled = false;
    public GameObject cubePrefab;
    public GameObject carriage;
    public GameObject carriageValve;
    private Stack<GameObject> cubes = new Stack<GameObject>();

    public void onToggle()
    {
        if (!isLatheEnabled) CreateCube();
        else DestroyCube();
        isLatheEnabled = !isLatheEnabled;

    }

    public void MoveCarriage()
    {
        Debug.Log(carriageValve.transform.rotation);
        carriage.transform.position = new Vector3(carriage.transform.position.x, carriageValve.transform.rotation.y, carriage.transform.position.z);
    }
    private void CreateCube()
    {
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
        Debug.Log("lathe");
    }

    // Update is called once per frame
    void Update()
    {
        // MoveCarriage();
    }
}
