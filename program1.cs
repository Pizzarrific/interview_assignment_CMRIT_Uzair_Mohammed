public class Problem1{  
         public static bool dupe(int[] p1){
        for (int i=0;i<p1.Length;i++){
            for (int j=i+1;j<p1.Length;j++){
                if (p1[i]==p1[j]){
                    return true;
                }}}
        return false;
    }
}
