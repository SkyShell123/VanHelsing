﻿using UnityEngine;
using System.Collections.Generic;
using RootMotion.Dynamics;


namespace BeastHunter
{
    public sealed class CharacterModel
    {
        #region Properties

        public GameObject CurrentWeapon { get; set; }
        public WeaponData CurrentWeaponData { get; set; }
        public WeaponHitBoxBehavior FirstWeaponBehavior { get; set; }
        public WeaponHitBoxBehavior SecondWeaponBehavior { get; set; }

        public Transform CharacterTransform { get; }
        public CapsuleCollider CharacterCapsuleCollider { get; }
        public SphereCollider CharacterSphereCollider { get; }
        public Rigidbody CharacterRigitbody { get; }
        public PlayerBehavior PlayerBehavior { get; }
        public CharacterData CharacterData { get; }
        public CharacterCommonSettingsStruct CharacterCommonSettings { get; }
        public BaseStatsClass CharacterStatsSettings { get; }
        public PuppetMaster PuppetMaster { get; }
        public BehaviourPuppet BehaviorPuppet { get; }
        public BehaviourFall BehaviorFall { get; }

        public Animator CharacterAnimator { get; set; }
        public List<Collider> EnemiesInTrigger { get; set; }
        public Collider ClosestEnemy { get; set; }

        public float CurrentSpeed { get; set; }
        public float AnimationSpeed { get; set; }
        public float Health { get; set; }

        public bool IsDodging { get; set; }
        public bool IsSneaking { get; set; }
        public bool IsGrounded { get; set; }
        public bool IsInBattleMode { get; set; }
        public bool IsEnemyNear { get; set; }
        public bool IsWeaponInHands { get; set; }
        public bool IsDead { get; set; }

        #endregion


        #region ClassLifeCycle

        public CharacterModel(GameObject prefab, CharacterData characterData, Vector3 groundPosition)
        {
            CharacterData = characterData;
            CharacterCommonSettings = CharacterData._characterCommonSettings;
            CharacterStatsSettings = CharacterData._characterStatsSettings;
            CharacterTransform = prefab.transform.GetChild(2).transform;
            CharacterTransform.rotation = Quaternion.Euler(0, CharacterCommonSettings.InstantiateDirection, 0);
            CharacterTransform.name = CharacterCommonSettings.InstanceName;
            CharacterTransform.tag = CharacterCommonSettings.InstanceTag;

            if (CharacterTransform.GetComponent<Rigidbody>() != null)
            {
                CharacterRigitbody = CharacterTransform.GetComponent<Rigidbody>();
            }
            else
            {
                CharacterRigitbody = CharacterTransform.gameObject.AddComponent<Rigidbody>();
                CharacterRigitbody.freezeRotation = true;
                CharacterRigitbody.mass = CharacterCommonSettings.RigitbodyMass;
                CharacterRigitbody.drag = CharacterCommonSettings.RigitbodyDrag;
                CharacterRigitbody.angularDrag = CharacterCommonSettings.RigitbodyAngularDrag;
            }

            CharacterRigitbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

            if (CharacterTransform.GetComponent<CapsuleCollider>() != null)
            {
                CharacterCapsuleCollider = CharacterTransform.GetComponent<CapsuleCollider>();
            }
            else
            {
                CharacterCapsuleCollider = CharacterTransform.gameObject.AddComponent<CapsuleCollider>();
                CharacterCapsuleCollider.center = CharacterCommonSettings.CapsuleColliderCenter;
                CharacterCapsuleCollider.radius = CharacterCommonSettings.CapsuleColliderRadius;
                CharacterCapsuleCollider.height = CharacterCommonSettings.CapsuleColliderHeight;
                CharacterCapsuleCollider.material = CharacterCommonSettings.CapsuleColliderPhysicMaterial;
            }

            CharacterCapsuleCollider.transform.position = groundPosition;

            if (CharacterTransform.GetComponent<SphereCollider>() != null)
            {
                CharacterSphereCollider = CharacterTransform.GetComponent<SphereCollider>();
                CharacterSphereCollider.isTrigger = true;
            }
            else
            {
                CharacterSphereCollider = CharacterTransform.gameObject.AddComponent<SphereCollider>();
                CharacterSphereCollider.center = CharacterCommonSettings.SphereColliderCenter;
                CharacterSphereCollider.radius = CharacterCommonSettings.SphereColliderRadius;
                CharacterSphereCollider.isTrigger = true;
            }

            CharacterAnimator = prefab.transform.GetChild(2).GetComponent<Animator>();
            PuppetMaster = prefab.transform.GetChild(1).gameObject.GetComponent<PuppetMaster>();
            BehaviorPuppet = prefab.transform.GetChild(0).GetChild(0).gameObject.GetComponent<BehaviourPuppet>();
            BehaviorFall = prefab.transform.GetChild(0).GetChild(1).gameObject.GetComponent<BehaviourFall>();

            CharacterAnimator.runtimeAnimatorController = CharacterCommonSettings.CharacterAnimator;
            CharacterAnimator.applyRootMotion = CharacterCommonSettings.BeginningApplyRootMotion;

            if (prefab.GetComponent<PlayerBehavior>() != null)
            {
                PlayerBehavior = prefab.GetComponent<PlayerBehavior>();
            }
            else
            {
                PlayerBehavior = prefab.AddComponent<PlayerBehavior>();
            }

            PlayerBehavior.SetType(InteractableObjectType.Player);
            PlayerBehavior.Stats = CharacterStatsSettings;

            EnemiesInTrigger = new List<Collider>();
            ClosestEnemy = null;
            IsGrounded = false;
            IsSneaking = false;
            IsEnemyNear = false;
            IsInBattleMode = false;
            IsWeaponInHands = false;
            IsDead = false;

            CurrentSpeed = 0;
            AnimationSpeed = CharacterData._characterCommonSettings.AnimatorBaseSpeed;

            Services.SharedInstance.CameraService.Initialize(this);

            CurrentWeapon = null;
            CurrentWeaponData = null;
        }

        #endregion
    }
}
