using System;

class TestProblem1{
    static void Main(){
        int[][] test = {
            new int[] {1,2,3,-1},new int[] {1,2,-3,4},new int[] {1,1,1,3,3,4,3,2,4,2},new int[] {0,0,0,1}};
        foreach(var arr in test){
            bool result = Problem1.ContainsDuplicate(arr);
            Console.WriteLine("[" + string.Join(",", arr) + "] - " + result);

        }
    }
}
