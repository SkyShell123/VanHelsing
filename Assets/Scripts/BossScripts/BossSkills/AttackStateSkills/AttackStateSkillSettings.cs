﻿using System;
using UnityEngine;


namespace BeastHunter
{

    [Serializable]
    public struct AttackStateSkillsSettings
    {
        #region Fields

        [Header("[Default Attack]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _defaultSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _defaultSkillIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _defaultSkillRangeMin;
        [Tooltip("Skill Range Max")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _defaultSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _defaultSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _defaultSkillReady;

        [Header("[Horizontal Attack]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _horizontalSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _horizontalSkillIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _horizontalSkillRangeMin;
        [Range(-1.0f, 30.0f)]
        [Tooltip("Skill Range Max")]
        [SerializeField] private float _horizontalSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _horizontalSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _horizontalSkillReady;

        [Header("[Stomp Splash]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _stompSplashSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _stompSplashSkillIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _stompSplashSkillRangeMin;
        [Range(-1.0f, 30.0f)]
        [Tooltip("Skill Range Max")]
        [SerializeField] private float _stompSplashSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _stompSplashSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _stompSplashSkillReady;

        [Header("[Rage Of Forest]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _rageOfForestSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _rageOfForestSkillIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _rageOfForestSkillRangeMin;
        [Range(-1.0f, 30.0f)]
        [Tooltip("Skill Range Max")]
        [SerializeField] private float _rageOfForestSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _rageOfForestSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _rageOfForestSkillReady;

        [Header("[Poison Spores]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _poisonSporesSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _poisonSporesIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _poisonSporesSkillRangeMin;
        [Range(-1.0f, 30.0f)]
        [Tooltip("Skill Range Max")]
        [SerializeField] private float _poisonSporesSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _poisonSporesSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _poisonSporesSkillReady;

        [Header("[Catch Attack]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _catchSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _catchSkillIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _catchSkillRangeMin;
        [Tooltip("Skill Range Max")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _catchSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _catchSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _catchSkillReady;

        [Header("[Finger Attack]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _fingerSkillId;
        [Tooltip("Is Active")]
        [SerializeField] private bool _fingerSkillIsActive;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _fingerSkillRangeMin;
        [Tooltip("Skill Range Max")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _fingerSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _fingerSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _fingerSkillReady;



        #endregion


        #region Properties

        public int DefaultSkillId => _defaultSkillId;
        public float DefaultSkillRangeMin => _defaultSkillRangeMin;
        public float DefaultSkillRangeMax => _defaultSkillRangeMax;
        public float DefaultSkillCooldown => _defaultSkillCooldown;
        public bool DefaultSkillReady => _defaultSkillReady;
        (int, float, float, float, bool) DefaultSkillTuple;

        public int HorizontalSkillId => _horizontalSkillId;
        public float HorizontalSkillRangeMin => _horizontalSkillRangeMin;
        public float HorizontalSkillRangeMax => _horizontalSkillRangeMax;
        public float HorizontalSkillCooldown => _horizontalSkillCooldown;
        public bool HorizontalSkillReady => _horizontalSkillReady;

        public int StompSplashSkillId => _stompSplashSkillId;
        public float StompSplashSkillRangeMin => _stompSplashSkillRangeMin;
        public float StompSplashSkillRangeMax => _stompSplashSkillRangeMax;
        public float StompSplashSkillCooldown => _stompSplashSkillCooldown;
        public bool StompSplashSkillReady => _stompSplashSkillReady;

        public int RageOfForestSkillId => _rageOfForestSkillId;
        public float RageOfForestSkillRangeMin => _rageOfForestSkillRangeMin;
        public float RageOfForestSkillRangeMax => _rageOfForestSkillRangeMax;
        public float RageOfForestSkillCooldown => _rageOfForestSkillCooldown;
        public bool RageOfForestSkillReady => _rageOfForestSkillReady;

        public int PoisonSporesSkillId => _poisonSporesSkillId;
        public float PoisonSporesSkillRangeMin => _poisonSporesSkillRangeMin;
        public float PoisonSporesSkillRangeMax => _poisonSporesSkillRangeMax;
        public float PoisonSporesSkillCooldown => _poisonSporesSkillCooldown;
        public bool PoisonSporesSkillReady => _poisonSporesSkillReady;

        public int CatchSkillId => _catchSkillId;
        public float CatchSkillRangeMin => _catchSkillRangeMin;
        public float CatchSkillRangeMax => _catchSkillRangeMax;
        public float CatchSkillCooldown => _catchSkillCooldown;
        public bool CatchSkillReady => _catchSkillReady;
        (int, float, float, float, bool) CatchSkillTuple;

        public int FingerSkillId => _fingerSkillId;
        public float FingerSkillRangeMin => _fingerSkillRangeMin;
        public float FingerSkillRangeMax => _fingerSkillRangeMax;
        public float FingerSkillCooldown => _fingerSkillCooldown;
        public bool FingerSkillReady => _fingerSkillReady;

        #endregion


        #region Methods

        public (int, float, float, float, bool, bool) GetDefaultSkillInfo()
        {
            var tuple = (DefaultSkillId, DefaultSkillRangeMin, DefaultSkillRangeMax, DefaultSkillCooldown, DefaultSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetHorizontalSkillInfo()
        {
            var tuple = (HorizontalSkillId, HorizontalSkillRangeMin, HorizontalSkillRangeMax, HorizontalSkillCooldown, HorizontalSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetStompSplashSkillInfo()
        {
            var tuple = (StompSplashSkillId, StompSplashSkillRangeMin, StompSplashSkillRangeMax, StompSplashSkillCooldown, StompSplashSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetRageOfForestSkillInfo()
        {
            var tuple = (RageOfForestSkillId, RageOfForestSkillRangeMin, RageOfForestSkillRangeMax, RageOfForestSkillCooldown, RageOfForestSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetPoisonSporesSkillInfo()
        {
            var tuple = (PoisonSporesSkillId, PoisonSporesSkillRangeMin, PoisonSporesSkillRangeMax, PoisonSporesSkillCooldown, PoisonSporesSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetCatchSkillInfo()
        {
            var tuple = (CatchSkillId, CatchSkillRangeMin, CatchSkillRangeMax, CatchSkillCooldown, CatchSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetFingerSkillInfo()
        {
            var tuple = (FingerSkillId, FingerSkillRangeMin, FingerSkillRangeMax, FingerSkillCooldown, FingerSkillReady, false);
            return tuple;
        }
        #endregion
    }
}