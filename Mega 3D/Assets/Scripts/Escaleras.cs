using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escaleras : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] TagId targetTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals(targetTag.ToString()) && Input.GetKeyDown(KeyCode.W))
        {
            player.escal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        player.escal = false;
    }
}
