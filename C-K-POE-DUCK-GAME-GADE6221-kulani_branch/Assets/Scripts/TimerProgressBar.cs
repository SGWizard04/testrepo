using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class TimerProgressBar : MonoBehaviour
{
    public RectTransform iconTransform;
    
    public float timeMax = 60f;
    public float timeCurrent;
    [Header("Position Settings")]
    public float startX = -200f;
    public float endX = 200f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeCurrent = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCurrent < timeMax)
        {
            timeCurrent += Time.deltaTime;
            
            float progress = timeCurrent / timeMax;
            float newX = Mathf.Lerp( startX , endX , progress);
            iconTransform.anchoredPosition = new Vector2(newX, iconTransform.anchoredPosition.y);
        }
        else
        {
            timeCurrent = 0;
            Debug.Log("RING RING");
        }
        
    }
}
