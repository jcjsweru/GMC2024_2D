using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform Player?
    
    private Vector3 camPos = new Vector3(0, 0, -10); // �������� ������

    void Update()��
    {
     �� transform.position = Player.position + camPos? ��
    }
}
