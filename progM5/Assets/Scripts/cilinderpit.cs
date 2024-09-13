using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class cilinderpit : MonoBehaviour
{
    public GameObject newCillinder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            Vector3 randomPos = new Vector3(x, 1f, z);
            CreateCillinder(randomPos);



        }
    }

    public void CreateCillinder(Vector3 position)
    {
        float Randomsize = Random.Range(1.0f, 5.0f);
        Vector3 randScale = new Vector3(Randomsize, Randomsize, Randomsize);
        transform.localScale = randScale;
        GameObject cillinder = Instantiate(newCillinder, (position), Quaternion.identity);
        cillinder.transform.localScale = randScale;

    }

    private void OnMouseDown()
    {
      
        
    }

    
}
