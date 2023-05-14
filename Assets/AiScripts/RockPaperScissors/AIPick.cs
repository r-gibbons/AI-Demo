using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPick : MonoBehaviour
{
    public int offset = 10;
    public int chooseMove(int userPick)
    {
        
        if (Random.Range(0, offset) == 0)
        {
            offset++;
            if(userPick == 0)
            {
                return 1;
            }
            else if(userPick == 1)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            
            
            int pick = Random.Range(0, 3);
            if (userPick == 0)
            {
                if(pick == 0)
                {
                    return 0;
                }
                else
                {
                    --offset;
                    return 2;
                }
            }
            else if (userPick == 1)
            {
                if (pick == 1)
                {
                    return 1;
                }
                else
                {
                    --offset;
                    return 0;
                }
            }
            else
            {
                if(pick ==2)                {
                    return 2;
                }
                else
                {
                    --offset;
                    return 1;
                }
            }
            
        }
        
    }
}
