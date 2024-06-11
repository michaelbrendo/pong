using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    public Color colorPlayer = Color.white;
    public Color colorEnemy = Color.white;

    private static SaveController _instance;

    public static SaveController Instance
    {
        get
        {
            if (_instance == null)
            {
                //Search for the instance in the scene
                _instance = FindObjectOfType<SaveController>();

                //Create a new one if not found
                if( _instance == null )
                {
                    GameObject singletonObject = new GameObject(typeof(SaveController).Name);
                    _instance = singletonObject.AddComponent<SaveController>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        //Check if just one istance exists 
        if ( _instance != null && _instance != this) 
        {
            Destroy(this.gameObject);
            return;
        }

        //Keep the singleton alive between scenes
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


}
