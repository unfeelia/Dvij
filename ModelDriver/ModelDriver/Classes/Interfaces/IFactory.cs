namespace ModelDriver.Classes
{
    internal interface IFactory
    {
        IMapObject GetByTemplate(string template);
        IMapObject GetByJson(string json);
    }
}