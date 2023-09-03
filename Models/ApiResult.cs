using System.Runtime.InteropServices;

namespace EYPractice.Model{
    public class ApiResult{
        public string status{get;set;}
        public int code {get;set;}
        public string data {get;set;}       
        public string message {get;set;}
    }
}