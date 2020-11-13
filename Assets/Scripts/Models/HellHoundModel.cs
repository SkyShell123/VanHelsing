﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace BeastHunter
{
    public sealed class HellHoundModel : EnemyModel
    {

        #region Fields

        private HellHoundData hellHoundData;
        private Animator animator;

        #endregion


        #region Properties

        public GameObject HellHound { get; }

        #endregion


        #region ClassLifeCycle

        public HellHoundModel(GameObject gameObject, HellHoundData hellHoundData)
        {
            this.hellHoundData = hellHoundData;
            HellHound = gameObject;
            animator = HellHound.GetComponent<Animator>();

            CurrentHealth = this.hellHoundData.BaseStats.MainStats.MaxHealth;
            IsDead = false;
        }

        #endregion


        #region Methods

        public void OnDead()
        {
            animator.SetBool("IsDead", true);
            HellHound.GetComponent<Rigidbody>().isKinematic = true;
            HellHound.GetComponent<BoxCollider>().enabled = false;
        }

        #endregion


        #region EnemyModel

        public override void DoSmth(string how)
        {
            hellHoundData.Do(how);
        }

        public override void Execute()
        {
            if (!IsDead)
            {
                hellHoundData.Act(this);
            }
        }

        public override EnemyStats GetStats()
        {
            return hellHoundData.BaseStats;
        }

        public override void OnAwake()
        {
            
        }

        public override void OnTearDown()
        {
            
        }

        public override void TakeDamage(Damage damage)
        {
            if (!IsDead)
            {
                hellHoundData.TakeDamage(this, damage);
            }
        }

        #endregion

    }
}
