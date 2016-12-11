using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Models.Contracts
{
    public interface IMarkFactory
    {
        IMark CreateMark(Subject subject, float mark);
    }
}
