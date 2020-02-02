using System;

namespace Domain.Seedwork
{
    public sealed class AutoInject : Attribute
    {
        public Type SourceType { get; }

        public AutoInject(Type sourceType)
        {
            SourceType = sourceType;
        }
    }
}
