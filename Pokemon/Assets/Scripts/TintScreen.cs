using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TintScreen : MonoBehaviour
{
    [SerializeField] Image screenCover;
    [SerializeField] Color untintedColor;
    [SerializeField] Color tintedColor;
    float t;
    [SerializeField] float speed;

    [ContextMenu("Tint")]

    public void Tint(){
        StopAllCoroutines();
        t = 0f;
        StartCoroutine(TintScreenCoroutine());
    }

    [ContextMenu("Untint")]
    public void Untint(){
        StopAllCoroutines();
        t = 0f;
        StartCoroutine(UntintScreenCoroutine());
    }

    IEnumerator TintScreenCoroutine(){
        while(t < 1f){
            t += Time.deltaTime * speed;
            t = Mathf.Clamp01(t);

            Color c = screenCover.color;
            c = Color.Lerp(untintedColor, tintedColor, t);
            screenCover.color=c;

            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator UntintScreenCoroutine(){
        while(t<1f){
            t+= Time.deltaTime * speed;
            t = Mathf.Clamp01(t);

            Color c = screenCover.color;
            c = Color.Lerp(tintedColor, untintedColor, t);
            screenCover.color = c;

            yield return new WaitForEndOfFrame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
