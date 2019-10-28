﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera _camera;
    void Start()
    {
        // доступ к другим компонентам, присоединенным к этому объекту
        _camera = GetComponent();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // середина экрана
            Vector3 point = new Vector3(_camera.pixelWidth/2, _camera.pixelHeight/2, 0);
            // создаем программный объект Ray
            Ray ray = _camera.ScreenPointToRay(point);
            // создаем структуру данных, которая содержит в себе информацию о точке выходи и объекте столкновения луча
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Debug.Log("Hit " + hit.point);
            }
        }
    }
}