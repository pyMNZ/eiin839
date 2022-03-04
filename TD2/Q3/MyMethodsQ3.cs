namespace BasicWebServer
{
    internal class MyMethodsQ3
    {

        // Question 3
        // URL: http://localhost:8080/Incr?param1=5
        public string Incr(string param1)
        {
            int val = int.Parse(param1);
            string str = "{ \"orignal_value\": " + val + ", \"incr_value\": " + ++val + "}";
            return str;
        }
    }
}
