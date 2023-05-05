using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRing : MonoBehaviour
{
    [SerializeField] GameObject m_RingPrefab;
    GameObject childobject;
    [SerializeField] int m_NoOfRings = 0;
    private void Start()
    {
        childobject = m_RingPrefab;
        childobject.transform.SetParent(m_RingPrefab.transform);
    }
    void InstantiateRing()
    {
        
        for(int i=0; i< m_NoOfRings; i++)
        {
            
            childobject.transform.position = new Vector3(m_RingPrefab.transform.position.x, (m_RingPrefab.transform.position.y + (i - 0.3f)), m_RingPrefab.transform.position.z); 
            Instantiate(childobject, childobject.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ring")
        {
            InstantiateRing();
        }
    }
}
