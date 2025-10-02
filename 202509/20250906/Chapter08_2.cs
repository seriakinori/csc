using System;
using System.Linq;
using System.Collections.Generic;

namespace Chapter08;

public class Program
{
    public class WordsExtractor{
        private readonly IEnumerable<string> _lines;
        
        public WordsExtractor(IEnumerable<string> lines){
            _lines = lines;
        }

        public IEnumerable<string> Extract(){
            var hash = new HashSet<string>();
            foreach(var line in _lines){
                var words = GetWords(line);
                foreach(var word in words){
                    if(word.Length >= 10){
                        hash.Add(word.ToLower());
                    }
                }
            }
            return hash.Order();
        }

        private readonly char[] _separators = @" !?"",.".ToCharArray();

        private IEnumerable<string> GetWords(string line){
            var items = line.Split(_separators, StringSplitOptions.RemoveEmptyEntries);    
            foreach(var item in items){
                var index = item.IndexOf("'");
                var word = index <= 0 ? item : item.Substring(0,index);

                if(word.ToLower().All(c => 'a' <= c && c <= 'z')){
                    yield return word;
                }
            }
        }
    }

    //static void Main(string[] args){
    void main(){
        var lines = File.ReadAllLines("sample.txt");
        var we = new WordsExtractor(lines);
        foreach(var word in we.Extract()){
            Console.WriteLine(word);
        }
    }
}
