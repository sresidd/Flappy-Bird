using UnityEngine;
using System.Collections;

public class ObstacleSpawnwer : MonoBehaviour
{
    [SerializeField] GameObject Object;
    Camera cam;
    float camHalfHeight,
        camHalfWidth;
    [SerializeField] Vector2 Offset;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        camHalfHeight = cam.orthographicSize;
        camHalfWidth = camHalfHeight * cam.aspect;
        StartCoroutine(ObstacleSpawn());
    }

    IEnumerator ObstacleSpawn(){
        yield return new WaitForSeconds(Random.Range(3,5));
        float randomSpawnPointY = Random.Range(-camHalfHeight + Offset.y,camHalfHeight- Offset.y);
        Vector2 spawnPoint = new Vector2(camHalfWidth + Offset.x,randomSpawnPointY);
        Instantiate(Object,spawnPoint,Quaternion.identity);
        StartCoroutine(ObstacleSpawn());
    }
}
