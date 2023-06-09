using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRing : MonoBehaviour
{
    [SerializeField] GameObject m_InstanRing;
    [SerializeField] GameObject m_RingPrefab;
    GameObject childobject;
    [SerializeField] int m_NoOfRings = 0;
    bool m_IsInTrigger = false;
    private void Start()
    {
        childobject = m_RingPrefab;
        childobject.transform.SetParent(m_RingPrefab.transform);
    }
    void InstantiateRing()
    {
        Vector3 transpos = new Vector3(m_RingPrefab.transform.position.x, (m_RingPrefab.transform.position.y - 0.25f), m_RingPrefab.transform.position.z);
        for(int i=0; i< m_NoOfRings; i++)
        {
            if (m_IsInTrigger)
            {
                m_IsInTrigger = false;
                Instantiate(m_InstanRing, transpos, Quaternion.identity);
                //m_RingPrefab.transform.parent = m_InstanRing.transform;
            }
            //childobject.transform.position = new Vector3(m_RingPrefab.transform.position.x, (m_RingPrefab.transform.position.y + (i - 0.3f)), m_RingPrefab.transform.position.z); 
            //Instantiate(childobject, childobject.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ring")
        {
            Debug.Log("Instantiate Ring");
            m_IsInTrigger = true;
            InstantiateRing();
            m_IsInTrigger = false;
        }
    }
}
