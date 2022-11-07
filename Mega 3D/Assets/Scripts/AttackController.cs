using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    [SerializeField] private float tiempoDeEspera;
    private float tiempoAtaque;
    private bool puedoAtacar = true;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tiempoAtaque -= Time.deltaTime;
        if (puedoAtacar == true && Input.GetKey(KeyCode.Space) && counter < 3)
        {
            InstanciarBala();
            puedoAtacar = false;
            tiempoAtaque = tiempoDeEspera;
            return;
        }

        if (tiempoAtaque <= 0)
        {
            puedoAtacar = true;
        }
    }
    void InstanciarBala()
    {
        bullet.transform.position = player.transform.position + new Vector3(18,9,0);
        Instantiate(bullet);
        counter += 1;
    }
}
