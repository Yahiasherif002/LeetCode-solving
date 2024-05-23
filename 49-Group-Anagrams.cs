public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
    var group= new Dictionary<string, IList<string>>();

    foreach(string str in strs){
        char[] hash=new char[26];
        foreach(char c in str){
            hash[c-'a']++;
        }
        string key=new string(hash);
        if(!group.ContainsKey(key)){
            group[key]=new List<string>();
        }
        group[key].Add(str);
    }

    return group.Values.ToList();

    }
}