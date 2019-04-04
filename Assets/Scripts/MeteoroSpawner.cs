using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawner : MonoBehaviour
{

    public GameObject meteoroPrefab;
    public Transform origin;
    private List<GameObject> meteores = new List<GameObject>();

    private float time;
    public float timeSpawn;

    private GameManager gm;
    // Use this for initialization
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

        if (gm.gameIsPlaying)
        {

            time += Time.deltaTime;

            if (time > timeSpawn)
            {

                float x, y, z;

                do
                {
                    y = Random.Range(-25f, 25f);
                } while (y > -5 && y < 5);

                do
                {
                    x = Random.Range(-25f, 25f);
                } while (x > -5 && x < 5);

                do
                {
                    z = Random.Range(-25f, 25f);
                } while (z > -5 && z < 5);


                Vector3 desiredPos = origin.position + new Vector3(x, y, z);
                //  Debug.Log(desiredPos);
                meteores.Add(Instantiate(meteoroPrefab, desiredPos, Quaternion.identity));
                time = 0;

            }
        }

    }

    public void clearMeteores() {

        for (int i = 0; i < meteores.Count; i++)
            Destroy(meteores[i].gameObject);

        meteores.Clear();

    }
}
