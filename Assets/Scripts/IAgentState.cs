using UnityEngine;
using System.Collections;

public interface IAgentState
{

    void UpdateState();

    void OnTriggerEnter(Collider other);

    void ToWorkState();

    void ToLeisureState();

    void ToNeedState();
}
