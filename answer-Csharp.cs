using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        List<int> lst = new List<int>(array);
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int nStart = commands[i, 0];
            int nEnd = commands[i, 1];
            int nIndex = commands[i, 2];
            List<int> lstSub = lst.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();
            answer[i] = lstSub[nIndex - 1];
        }
        return answer;
    }
}
