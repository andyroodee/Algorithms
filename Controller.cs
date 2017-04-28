using System;
using System.Reflection;

namespace Algorithms
{
    public class Controller
    {
        private const string ClientTypeNameTemplate = "Algorithms.Clients.{0}Client";
        private const int ClientArgsIndex = 2;

        public static void RunClient(string[] args)
        {
            string typeName = args[0];
            string methodName = args[1];

            Assembly algsAssembly = Assembly.GetExecutingAssembly();
            Type type = algsAssembly.GetType(string.Format(ClientTypeNameTemplate, typeName), true, true);
            MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static);
            ArraySegment<string> seg = new ArraySegment<string>(args, ClientArgsIndex, args.Length - ClientArgsIndex);
            methodInfo.Invoke(null, new object[] { args });
        }

        public static void Main(string[] args)
        {
            RunClient(args);
        }
    }
}
