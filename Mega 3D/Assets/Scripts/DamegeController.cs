using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeController : MonoBehaviour
{
    public GameObject bala;
    [SerializeField] float vel;
    public AttackController coun;
    [SerializeField] TagId targetTag;

    // Start is called before the first frame update
    void Start()
    {
        coun = FindObjectOfType<AttackController>();
        Debug.Log(coun.counter);
    }

    // Update is called once per frame
    void Update()
    {
        bala.transform.Translate(vel * Time.deltaTime, 0, 0);
    }

    private void OnBecameInvisible()
    {
        Debug.Log("adios");
        gameObject.SetActive(false);    
        Destroy(gameObject);
        coun.counter -= 1;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals(targetTag.ToString()))
        {
            return;
        }
        Debug.Log("colision");
        Destroy(gameObject);
    }
}
