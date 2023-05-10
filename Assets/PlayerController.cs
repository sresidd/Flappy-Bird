using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public event System.Action OnBlockPassed, OnObstacleCollision;
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float impulseForce = 10f;
    // private bool canFly = false;

    void Start()
    {
        if(rb2D==null)rb2D = FindObjectOfType<Rigidbody2D>();
        // canFly = true;
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
            rb2D.velocity = Vector2.up * impulseForce;
            // rb2D.AddForce(Vector2.up * impulseForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Obstacles")){
            // canFly = false;
            Destroy(gameObject);
            OnObstacleCollision?.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("CoinIncrement")){
            OnBlockPassed?.Invoke();
        }
    }
}
