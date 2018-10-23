using UnityEngine;

public class TriggerScript : MonoBehaviour {

    [SerializeField] private TargetScript[] targets;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        if (targets == null) return;
        foreach(TargetScript tgt in targets) {
            tgt.Action();
        }
    }
}
