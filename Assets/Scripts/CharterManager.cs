using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharterManager : MonoBehaviour
{
    private static CharterManager _instance;

    public static CharterManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("CharterManager").AddComponent<CharterManager>();
            }
            return _instance;
        }
    }

    public Player _Player;

    public Player Player
    {
        get { return _Player; }
        set { _Player = value; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    
}
