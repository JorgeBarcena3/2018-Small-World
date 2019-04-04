using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoro : MonoBehaviour
{

    public GameObject afterColliison;
    public GameObject beforeCollision;
    public GameObject particlesBeforeCollision;
    public GameObject particlesAfterCollision;

    private float timer = 0;
    public float lifetime;
    private GameManager gm;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        afterColliison.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isTheMeteorAlive)
            isLife();


    }

    private bool isTheMeteorAlive = true;

    private void isLife()
    {

        if (timer <= lifetime && afterColliison.activeSelf)
            timer += Time.deltaTime;
        else
        if (timer > lifetime)
        {

            Destroy(particlesAfterCollision);
            isTheMeteorAlive = false;

        }

        //if (!particlesBeforeCollision.GetComponent<ParticleSystem>().isPlaying)
        //    Destroy(particlesBeforeCollision);


    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name == "Planet")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            afterColliison.SetActive(true);
            Destroy(beforeCollision);
            // beforeCollision.SetActive(false);
            // Destroy(particlesBeforeCollision);
            particlesAfterCollision.GetComponent<ParticleSystem>().Play();
            gameObject.isStatic = true;

        }
        else if (collision.gameObject.name == "Player")
        {

            gm.gameIsPlaying = false;
        }

    }
}
