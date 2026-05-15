using System.Collections;
using UnityEngine;

public class ActiveManager : MonoBehaviour
{
    public float timer = 0;
    private bool isActivated = false; // Flag to track if the script has been activated
    public bool winManagerEnabled = false;
    public static ActiveManager instance;
    [Header("Settings")]
    public float moveSpeed = 1f;
    public float moveDistance = 1f;
    public GameObject bossObject;
    public GameObject WinBanner;
    public MonoBehaviour targetScript;
    public MonoBehaviour winManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        bossObject.transform.position = new Vector3(0, -500 * Time.deltaTime, 0);
        if (targetScript != null)
        {
            targetScript.enabled = false; // Disable the target script at the start
            winManager.enabled = false; // Disable the win script at the start
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        if(!isActivated )
        {

            if (timer >= 30f)
            {
                ActivateClass();
                RiseNFall();
            }
        }
            if (timer >= 59f && !winManagerEnabled)
            {
               Destroy(bossObject);
                winManagerEnabled = true;
            }
        

    }
        void RiseNFall()
        {
            if (isActivated == true)
            {
                bossObject.transform.position += new Vector3(12, 51 , 446);
            }
            else
            {
                bossObject.transform.position += new Vector3(0, -500 * Time.deltaTime, 0);
            }
            
        }
        void ActivateClass()
        {
            if (targetScript != null)
            {
                targetScript.enabled = true;
                
                isActivated = true;
            }
        }
    private void OnEnable()
    {
        WinBanner.transform.position -= transform.forward * moveDistance * Time.deltaTime;

    }


}
