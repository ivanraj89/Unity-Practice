using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IExplodable
{
    public void Explode();
}
public class NewScript : MonoBehaviour, IExplodable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1, 0);
        

    }
    public void Explode();
}
