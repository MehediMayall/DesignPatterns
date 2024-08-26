namespace SchoolHR.Domain;

public static class EmployeeGenericFactory<K,T> where T : class, K, new()  
{
    public static K GetInstance()
    {
        K baseObj;
        baseObj = new T();
        return baseObj;
    }
}
