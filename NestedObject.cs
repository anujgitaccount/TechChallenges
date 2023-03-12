using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
namespace GetNestedValueByKey {
    class Program {
        static void Main(string[] args) {
            static object GetValueByKey(JObject obj, string key) {
                var keys = key.Split('/');
                JToken current = obj;
                foreach(var ky in keys) {
                    current = current[ky];
                    if (current == null) return $ "Key {key} not exists";
                }
                return current;
            }
            
            /*Tests*/
            JObject obj = JObject.Parse("{\"a\":{\"b\":{\"c\":\"d\"}}}");
            var value = GetValueByKey(obj, "a/b/c");
            Console.WriteLine(value); // Output: "d"
            obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
            value = GetValueByKey(obj, "x/y/z");
            Console.WriteLine(value); // Output: "a"
           
        }
    }
}
