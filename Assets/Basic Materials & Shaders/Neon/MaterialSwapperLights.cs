using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwapperLights : MonoBehaviour
{
    public float changeInterval;
    public float timer;
    public int randomNum;

    public Material[] myMats;

    public Material matOne;
    public Material matTwo;
    public Material matThree;


    void Start()
    {
        myMats = GetComponent<Renderer>().materials;
        //myMats[0] = matOne;
        //myMats[1] = matTwo;
        //myMats[2] = matThree;
        gameObject.GetComponent<Renderer>().materials = myMats;

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            randomNum = Random.Range(0, myMats.Length);
            timer = 0;
        }



        if (randomNum == 0)
        {
            myMats[0] = matTwo;
            myMats[1] = matThree;
            myMats[2] = matOne;
            gameObject.GetComponent<Renderer>().materials = myMats;
        }

        if (randomNum == 1)
        {
            myMats[0] = matThree;
            myMats[1] = matOne;
            myMats[2] = matTwo;
            gameObject.GetComponent<Renderer>().materials = myMats;
        }

        if (randomNum == 2)
        {
            myMats[0] = matOne;
            myMats[1] = matTwo;
            myMats[2] = matThree;
            gameObject.GetComponent<Renderer>().materials = myMats;
        }
    }
}
