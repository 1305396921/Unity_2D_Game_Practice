using UnityEngine;

public class Clone_Skill : Skill
{
    [SerializeField] private GameObject clonePrefab;
    [SerializeField] private float cloneDuration;
    [Space]
    [SerializeField] private bool canAttack;
    public void CreateClone(Transform _clonePosition)
    {
        //possible solution
        //clonePrefab.transform.position = PlayerManager.instance.player.transform.position;

        GameObject newClone = Instantiate(clonePrefab);
        newClone.GetComponent<Clone_Skill_Controller>().SetUpClone(_clonePosition, cloneDuration, canAttack);
    }
}
