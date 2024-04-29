    static const struct Original {
        HANDLE InputHandle;
        HANDLE OutputHandle;
        HANDLE ErrorHandle;
        HANDLE Read;
        HANDLE Write;
        Original() :
            InputHandle(GetStdHandle(STD_INPUT_HANDLE)),
            OutputHandle(GetStdHandle(STD_OUTPUT_HANDLE)),
            ErrorHandle(GetStdHandle(STD_ERROR_HANDLE)),
            Read(NULL), Write(NULL)
        {
            BOOL Ret = CreatePipe(&Read, &Write, NULL, 0);
            if (Ret == FALSE) { return; }
            SetStdHandle(STD_INPUT_HANDLE, Read);
            SetStdHandle(STD_OUTPUT_HANDLE, Write);
        };
        ~Original()
        {
            SetStdHandle(STD_INPUT_HANDLE, InputHandle);
            SetStdHandle(STD_OUTPUT_HANDLE, OutputHandle);
            CloseHandle(Read);
            CloseHandle(Write);
        };
    } Store{};