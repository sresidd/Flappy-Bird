using UnityEngine;
using System.Collections;

public class ObstacleSpawnwer : MonoBehaviour
{
    [SerializeField] GameObject Object;
    Camera cam;
    float camHalfHeight,
        camHalfWidth;
    [SerializeField] float yOffset;

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
        float randomSpawnPointY = Random.Range(-camHalfHeight + yOffset,camHalfHeight- yOffset);
        Vector2 spawnPoint = new Vector2(camHalfWidth,randomSpawnPointY);
        Instantiate(Object,spawnPoint,Quaternion.identity);
        StartCoroutine(ObstacleSpawn());
    }
}
