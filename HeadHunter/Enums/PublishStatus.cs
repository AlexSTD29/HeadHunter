using System;
using System.ComponentModel;

namespace HeadHunter.Enums
{
    public enum PublishStatus
    {
        [Description("Приватный")]
        Secure = 0,
        [Description("Публичный")]
        InPublic = 1
    }
}
