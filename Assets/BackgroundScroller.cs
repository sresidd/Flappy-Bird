using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroller : MonoBehaviour
{
    RawImage _img;
    [SerializeField]Vector2 scrollingSpeed;

    void Awake(){
        _img = GetComponent<RawImage>();
    }

    void Update(){
        _img.uvRect = new Rect(_img.uvRect.position + scrollingSpeed * Time.deltaTime,_img.uvRect.size);
    }
}
