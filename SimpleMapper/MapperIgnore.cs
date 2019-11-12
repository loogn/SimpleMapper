using System;
namespace SimpleMapper
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MapperIgnore : Attribute
    {
    }
}
