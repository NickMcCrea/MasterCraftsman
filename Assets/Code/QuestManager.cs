using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager
{

	

}

public class Quest
{
    public string name;
    public int id;
    public string description;
    public QuestState currentQuestState;

}

public enum QuestState
{
    notStarted,
    notEligible,
    inProgress,
    failed,
    success,
    complete
}

public abstract class Task
{
    
    public int taskId;
    //types of task - collect item(s), speak to person, activate object, go to position / location, perform task


    public abstract bool CheckComplete();
}

public class CollectItemTask : Task
{
    public PlayerInventory playerInventory;
    public int itemTypeId;

    public CollectItemTask(int idOfItem)
    {
        itemTypeId = idOfItem;
    }

    public override bool CheckComplete()
    {
        return playerInventory.HasItemOfType(itemTypeId);
    }

}


public class SpeakToPersonTask : Task
{
    public int npcId;

    public override bool CheckComplete()
    {
        throw new System.NotImplementedException();
    }
}



public class MasterCrafterObject
{
    public int objectId;
    public int typeId;
    public string name;
    public string description;
}

/// <summary>
/// Things which can be picked up
/// </summary>
public interface ICollectable 
{
    
}

/// <summary>
/// Things which can be consumed and have an effect.
/// </summary>
public interface IConsumable
{

}

/// <summary>
/// Things which can be equipped and used (e.g. axe)
/// </summary>
public interface IEquippable 
{
    void Use();
  
}

/// <summary>
/// Things which can be activated (i.e. doors, switches etc).
/// </summary>
public interface IActivatable
{
    void Use();
}
