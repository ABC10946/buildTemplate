using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class builder : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    private Command mouse = new BuildNode();

    // Start is called before the first frame update
    void Start()
    {
        mouse.setNode(cube);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) {
                mouse.Execute(hit.point);
            }
        }

        if(Input.GetMouseButtonDown(1)) {
            mouse.Undo();
        }
    }
}
