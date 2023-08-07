using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DraG.DefenseBasic
{
    public class Player : MonoBehaviour, IComponentChecking
    {
        public float atkRate;
        private Animator e_anim;
        private float m_curAtkRate;
        private bool m_isAttacked;
        private bool m_isDead;
        private void Awake()
        {
            e_anim = GetComponent<Animator>();
            m_curAtkRate = atkRate;
        }
        // Start is called before the first frame update
        void Start()
        {

        }
        public bool IsComponentsNull()
        {
            return e_anim == null;

        }
        // Update is called once per frame
        void Update()
        {
            if (IsComponentsNull()) return;
            if (Input.GetMouseButtonDown(0) && !m_isAttacked)
            {
                e_anim.SetBool(Const.ATTACK_ANIM, true);
                m_isAttacked = true;
            }
            if (m_isAttacked)
            {
                m_curAtkRate -= Time.deltaTime;
                if (m_curAtkRate < 0)
                {
                    m_isAttacked = false;
                    m_curAtkRate = atkRate;
                }
            }
        }
        public void ResetAtkAnim()
        {
            if (IsComponentsNull()) return;
            e_anim.SetBool(Const.ATTACK_ANIM, false);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsComponentsNull()) return;

            if (collision.CompareTag(Const.ENEMY_WEAPON_TAG) && !m_isDead)
            {
                e_anim.SetTrigger(Const.DEAD_ANIM);
                m_isDead = true;
            }
        }
    }
}
