using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    public float timer = 0;
    public List<GameObject> cubes = new List<GameObject>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cubes.Count);
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                var copycube = Instantiate(Cube);
                cubes.Add(copycube);
            }
        }
        if (timer >= 1)
        {
            
            for (int i = 0;i < 3;i++) 
            {
                
                var copycube = Instantiate(Cube);
                cubes.Add(copycube);
            }
            timer = 0;
        }
        if (Input.GetKeyDown (KeyCode.Q)) 
        {

            for (int i = 0; i < cubes.Count; i++)
            {
                Destroy(cubes[i].gameObject);
            }
            cubes.Clear();
        }
        
    }
}
