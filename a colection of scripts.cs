using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acolectionofscripts : MonoBehaviour
{
    // Here Are My scripts for all moving for the ml agents which it took to an extreme and started moving the box instead of the ball
    //Convert action to axis values
    // float forward = vectorAction[0];// alows for discrte timesteps to decide between 0 and 1 only moes on 1.
    // float leftOrRight = vectorAction[1];
    /*if (vectorAction[1] == 1f){
        leftOrRight = -1f;

    }
    else if (vectorAction[1] == 2f){
        leftOrRight = 1f;
    }*/





    //Later for animation



    //essentially these codes activate or at the very least would activate animations for the ml agents 
    // by fliping a float to on or off kinda like a boolean


    //animator.SetFloat("Vertical",forward);
    //animator.SetFloat("Horizontal, leftOrRight);
    // negative rewards
    //AddReward(-1f / agentParameters.maxStep);

    //Next we have the script for spawning in bananas very simple just chooses a random aread and adds a banana a collectable object


    //private void SpawnBanana(int count, float bananaSpeed)
    //{
    //    for (int i = 0; i < count; i++)
    //    {
    //        GameObject bananaObject = Instantiate<GameObject>(bananaPrefab.gameObject);
    //        bananaObject.transform.position = ChooseRandomPosition(transform.position, 100f, 260f, 2f, 13f) + Vector3.up * .5f;
    //        bananaObject.transform.rotation = Quaternion.Euler(0f, UnityEngine.Random.Range(0f, 360f), 0f);
    //        bananaObject.transform.parent = transform;
    //        bananaList.Add(bananaObject);
    //        bananaObject.GetComponent<Banana>().bananaSpeed = bananaSpeed;
    //    }



    //This next part is used for despawing a banana another code controlls it when it has a collision with player or ai in this case
    //}
    //private void RemoveAllBananas()
    //{
    //    if (bananaList != null)
    //    {
    //        for (int i = 0; i < bananaList.Count; i++)
    //        {
    //            if (bananaList[i] != null)
    //            {
    //                Destroy(bananaList[i]);
    //            }
    //        }
    //    }
    //    bananaList = new List<GameObject>();
    //}

    //Here is kind of a collision scirpt but it mostly a radius detection so see if both objects are 
    //    in range.
    //public override void CheckTransitions()
    //{
    //    //Checks if Dog or hunter is not in range to run to
    //    if (!stateController.CheckForDog("Dog"))
    //    {
    //        stateController.SetState(new PatrolState(stateController));

    //    }//Also Checks if player is not 
    //    if (!stateController.CheckIfInRange("Player"))
    //    {
    //        stateController.SetState(new PatrolState(stateController));

    //    }


    //Here is the set up for the state machine Ai


    //public class StateController : MonoBehaviour
    //{
    //    public State currentState;
    //    public GameObject[] navPoints;
    //    public GameObject enemyToChase;
    //    public int navPointNum;
    //    public float remainingDistance;
    //    public Transform destination;
    //    public UnityStandardAssets.Characters.ThirdPerson.AICharacterControl aI;
    //    public Renderer[] childrenRend;
    //    public GameObject[] enemies;
    //    public float detectionRange = 8;
    //    public float DogDetectionrange = 60;
    //    public GameObject[] Dog;
    //    public GameObject DogToChase;

    //    public Transform GetNextNavPoint()
    //    {
    //        navPointNum = (navPointNum + 1) % navPoints.Length;
    //        return navPoints[navPointNum].transform;
    //    }
    //    public void ChangeColor(Color color)
    //    {
    //        foreach (Renderer r in childrenRend)
    //        {
    //            foreach (Material m in r.materials)
    //            {
    //                m.color = color;
    //            }
    //        }
    //    }//this one detects objects with certain tags
    //    public bool CheckIfInRange(string tag)
    //    {
    //        enemies = GameObject.FindGameObjectsWithTag(tag);
    //        if (enemies != null)
    //        {
    //            foreach (GameObject g in enemies)
    //            {
    //                if (Vector3.Distance(g.transform.position, transform.position) < detectionRange)
    //                {
    //                    enemyToChase = g;
    //                    return true;
    //                }
    //            }
    //        }
    //        return false;
    //    }
    //    //Yay Here we have the dog code that allows the hunter or dog to run to each other
    //    public bool CheckForDog(string tag)
    //    {
    //        Dog = GameObject.FindGameObjectsWithTag("Dog");
    //        if (Dog != null)
    //        {
    //            foreach (GameObject d in Dog)
    //            {
    //                if (Vector3.Distance(d.transform.position, transform.position) < DogDetectionrange)
    //                {
    //                    DogToChase = d;
    //                    return true;
    //                }
    //            }
    //        }
    //        return false;
    //    }

    //    void Start()
    //    {
    //        //We have nave points that  allow for the ai to go to certain points
    //        navPoints = GameObject.FindGameObjectsWithTag("navpoint");
    //        aI = GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>();
    //        childrenRend = GetComponentsInChildren<Renderer>();
    //        //Set initial state
    //        SetState(new PatrolState(this));
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        currentState.CheckTransitions();
    //        currentState.Act();

    //    }
    //    public void SetState(State state)
    //    {
    //        if (currentState != null)
    //        {
    //            currentState.OnStateExit();
    //        }
    //        currentState = state;
    //        gameObject.name = "AI agent in state" + state.GetType().Name;
    //        if (currentState != null)
    //        {
    //            currentState.OnStateEnter();
    //        }
    //    }

    //}

}
