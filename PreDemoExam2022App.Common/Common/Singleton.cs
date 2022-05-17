namespace PreDemoExam2022App.Common.Common
{
    public static class Singleton<T> where T : class, new()
    {
        private static T _instance = null;

        public static T GetInstance() => _instance ??= new T();
    }
}
