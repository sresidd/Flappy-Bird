using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    [SerializeField]Transform upperBlock,
                                lowerBlock;
    [SerializeField] float velocity = 5f;
    [SerializeField] Vector2 offsetRange;

    void Start(){
        float randOffset = Random.Range(offsetRange.x,offsetRange.y);
        Vector3 offset = new Vector2(0,randOffset);
        upperBlock.position -= offset;
        lowerBlock.position += offset;
        Destroy(gameObject,6f);
    }
    void Update()
    {
        transform.Translate(Vector2.left * velocity * Time.deltaTime);
    }
}
