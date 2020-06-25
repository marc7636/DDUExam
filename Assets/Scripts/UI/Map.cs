using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public float speed = 2;
    public float zoomSpeed = 2;
    public KeyCode mapKey;
    private bool mapIsOpen = false;
    private GameObject camera;
    private GameObject mainCamera;

    public void StartMap()
    {
        camera = transform.GetChild(0).gameObject;
        camera.SetActive(false);
        mainCamera = Camera.main.gameObject;
    }

    void Update()
    {
        if (Input.GetKeyDown(mapKey))
        {
            mapIsOpen = !mapIsOpen;
            mainCamera.SetActive(!mapIsOpen);
            camera.SetActive(mapIsOpen);

            if (mapIsOpen)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }

        }
        if (mapIsOpen)
        {
            transform.Translate(Vector3.Normalize(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0)) * speed);
        }
    }
}
