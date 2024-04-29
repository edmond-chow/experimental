        static void Main(string[] args)
        {
            int i = 1234;
            Console.WriteLine(i.ToString());
            Console.WriteLine(int.TryParse(i.ToString(), out int _));



            Type string_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.String");     // typeof(string)
            Type int_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.Int32");         // typeof(int)
            Type bool_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.Boolean");      // typeof(bool)
            Type console_t = AppDomain.CurrentDomain.GetAssemblies()[0].GetType("System.Console");   // typeof(System.Console)

            object i_dyn = 1234;
            console_t.GetMethod("WriteLine", new Type[] { string_t }).Invoke(null, new object[] {
                int_t.GetMethod("ToString", new Type[] { }).Invoke(i_dyn, new object[] { })
            });
            console_t.GetMethod("WriteLine", new Type[] { bool_t }).Invoke(null, new object[] {
                int_t.GetMethod("TryParse", new Type[] { string_t, int_t.MakeByRefType() }).Invoke(null, new object[] {
                    int_t.GetMethod("ToString", new Type[] { }).Invoke(i_dyn, new object[] { }),
                    Activator.CreateInstance(int_t)
                })
            });
        }