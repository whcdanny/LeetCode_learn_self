public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> str = new Stack<string>();
        for(int i=0;i<path.Length;){
            while(i<path.Length && '/'==path[i]){
                ++i;
            }
            string s = "";
            while(i<path.Length && path[i]!='/'){
                s+=path[i++];
            }
            if(".."==s && str.Count!=0){
                str.Pop();
            }
            else if(s!="" && s!="." && s!=".."){
                str.Push(s);
            }
        }
        if(str.Count==0){
            return "/";
        }
        string ss="";
        while(str.Count!=0){
            ss="/"+str.First()+ss;
            str.Pop();
        }
        return ss;
    }
}