using AnyRPG;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AnyRPG {

    [CreateAssetMenu(fileName = "New Lootable Node Config", menuName = "AnyRPG/Interactable/LootableNodeConfig")]
    [System.Serializable]
    public class LootableNodeConfig : InteractableOptionConfig {

        [Header("Lootable Node")]

        [SerializeField]
        protected List<string> lootTableNames = new List<string>();

        [SerializeField]
        protected float spawnTimer = 5f;

        public List<string> LootTableNames { get => lootTableNames; set => lootTableNames = value; }
        public float SpawnTimer { get => spawnTimer; set => spawnTimer = value; }

        public virtual InteractableOption GetInteractableOption(Interactable interactable) {
            return new LootableNode(interactable, this);
        }
    }

}