using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�U�����󂯂܂���");
        if (other.tag == "BossAttack")
        {
            GManager.instance.ReducePlayerHP(3);
        }
    }
}
