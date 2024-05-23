    private static readonly ThreadLocal<StringBuilder> Builder = new ThreadLocal<StringBuilder>(() => { return new StringBuilder(); });
    private static StringBuilder Result
    {
        get { return Builder.Value; }
    }