using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
{
    // Получаем текущую позицию камеры
    Vector3 currentPosition = transform.position;

    // Получаем текущую позицию игрока
    Vector3 targetPosition = player.position;

    // Изменяем позицию камеры, чтобы она следовала за игроком
    currentPosition.x = targetPosition.x;
    currentPosition.y = targetPosition.y;
    transform.position = currentPosition;
}
}
