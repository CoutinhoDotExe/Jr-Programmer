using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Color TeamColor;
    // Start is called before the first frame update
    void Start()
    {
        if ( MainManager.Instance != null)
        {
            SetColor(MainManager.Instance.TeamColor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewColorSelected(Color color)
    {
        MainManager.Instance.TeamColor = color;
    }
    private void Awake()
    {
        if ( Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
