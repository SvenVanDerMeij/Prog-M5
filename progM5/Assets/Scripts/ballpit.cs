using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballpit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject newBall;
    private float elapsedTime = 0f;

    void Start()
    {
        for (int i = 0; i < 100; i++) 
        {


            Vector3 randomPos = posPicker();
            Color randColor = colorPicker();
            CreateBall(randColor, randomPos);
        }
    }

    // Update is called once per frame
    private void CreateBall(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(newBall, (position), Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
    }
    void Update()
    {
        

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            Vector3 randomPos = posPicker();
            Color randColor = colorPicker();
            CreateBall(randColor, randomPos);
            elapsedTime = 0f;
        }

    }

    Color colorPicker()
    {
        
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }

    Vector3 posPicker()
    {
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Vector3 randomPos = new Vector3(x, 1f, z);
        return randomPos;
    }
}
