using BBUnity.Conditions;
using Pada1.BBCore;
using UnityEngine.AI;

[Condition("CustomConditions/NotAtGuardPos")]
public class NotAtGuardPos : GOCondition
{
    public override bool Check()
    {
        return (gameObject.GetComponent<AIManager>().CheckAgentDistance(gameObject.GetComponent<NavMeshAgent>().transform.position,
            gameObject.GetComponent<AIManager>().GuardPosition.transform.position) > 1);
    }
}
