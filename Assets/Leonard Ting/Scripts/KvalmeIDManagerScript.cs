using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KvalmeIDManagerScript : MonoBehaviour
{
    [SerializeField] private KvalmeQuestionScript objIDHolder;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (id != objIDHolder.id) id = objIDHolder.id;
    }
}
