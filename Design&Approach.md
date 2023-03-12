# TODO:

# Challenge3:

We have a nested object. We would like a function where you pass in the object and a key and get back the value. 
The choice of language and implementation is up to you.

Example Inputs
object = {“a”:{“b”:{“c”:”d”}}}
key = a/b/c
object = {“x”:{“y”:{“z”:”a”}}}
key = x/y/z
value = a

# Approach:
* I am using the C# language as my programming background is .NET (C#). I have create a method which takes two parameters(object and key) and once the method is called   then we can split the key by "/" and check each level of the object. JObject class from the Newtonsoft.Json Nuget package can be used to parse and navigate a JSON     object.
* The function "GetValueByKey(JObject obj, string key), splits the key by '/' character, iterate over the keys array and on each iteration, it uses the key to get the   value at that key, until it reaches the last key. The value at the last key will be returned and if the key not found, it will return key does not exist.

# Test Scenarios:

            JObject obj = JObject.Parse("{\"a\":{\"b\":{\"c\":\"d\"}}}");
            var value = GetValueByKey(obj, "a/b/c");
            Console.WriteLine(value); // Output: "d"
            obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
            value = GetValueByKey(obj, "x/y/z");
            Console.WriteLine(value); // Output: "a"
