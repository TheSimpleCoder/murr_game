using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab_or_eny_name;
    private GameObject _enemy;

    void Update()
    {
        if (_enemy == null)
        {
            // Instantiate возвращает новый объект(как сущность) и мы приводим его к игровому объекту as GameObject 
            _enemy = Instantiate(enemyPrefab_or_eny_name) as GameObject;
            _enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}
