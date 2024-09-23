using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    [SerializeField] private GameObject groundSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnTrigger"))
        {
            Instantiate(groundSection, other.transform.position + new Vector3(10, 0, 0), Quaternion.identity);
        }
        if (other.gameObject.CompareTag("DestroyTrigger"))
        {
            Destroy(other.transform.parent.gameObject);
        }

    }
}
