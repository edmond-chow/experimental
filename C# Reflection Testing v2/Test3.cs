        static void m()
        {
            Console.WriteLine("Method");
        }
        static void m(ref int g)
        {
            Console.WriteLine("Method" + g.ToString());
        }
        static void Main(string[] args)
        {
            int i = 1234;
            Console.WriteLine(i.ToString());
            Console.WriteLine(int.TryParse(i.ToString(), out i));


            
            Type string_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.String");     // typeof(string)
            Type int_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.Int32");         // typeof(int)
            Type bool_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.Boolean");      // typeof(bool)
            Type console_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.Console");   // typeof(System.Console)
            Type ProgramType = AppDomain.CurrentDomain.GetAssemblies()[1].GetType("ConsoleApp1.Program");


            object i_dyn = 1234;
            console_t.GetMethod("WriteLine", new Type[] { string_t }).Invoke(null, new object[] {
                int_t.GetMethod("ToString", new Type[] { }).Invoke(i_dyn, new object[] { })
            });
            console_t.GetMethod("WriteLine", new Type[] { bool_t }).Invoke(null, new object[] {
                int_t.GetMethod("TryParse", new Type[] { string_t, int_t.MakeByRefType() }).Invoke(null, new object[] {
                    int_t.GetMethod("ToString", new Type[] { }).Invoke(i_dyn, new object[] { }),
                    i_dyn
                })
            });
            ProgramType.GetMethod("m", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { }, null).Invoke(null, new object[] { });
            ProgramType.GetMethod("m", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { int_t.MakeByRefType() }, null).Invoke(null, new object[] { 2364 });
        }