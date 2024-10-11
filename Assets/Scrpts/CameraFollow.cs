using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 offset;
    public float cameraSpeed;

    private Vector3 offsetAwal;
    private Vector3 offsetAkhir;


    private void Start()
    {

        offsetAkhir = offset;
        offsetAwal = offset;
    }

    // Update is called once per frame
    void Update()
    {

        

        transform.position = Vector3.Lerp(transform.position , playerPos.position + offset, cameraSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            offset = new Vector3(offset.x, offset.y - offsetAwal.y, offset.z);
            print(offsetAwal);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            offset = new Vector3(offset.x, offset.y + offsetAkhir.y, offset.z);
            print(offsetAkhir);
        }
    }
}
