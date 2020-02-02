using System;

namespace Domain.Seedwork
{
    public sealed class AutoInject : Attribute
    {
        public Type TargetType { get; }

        public AutoInject(Type targetType)
        {
            TargetType = targetType;
        }
    }
}
