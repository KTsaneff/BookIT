namespace BookIT.Infrastructure.Common
{
    public class ValidationConstants
    {
        public const int AdultsCountMinValue = 1;
        public const int ChildrenCountMinValue = 0;

        //User
        public const int UserNameMinLength = 2;
        public const int UserNameMaxLength = 30;

        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 30;

        public const int EmailMinLength = 9;
        public const int EmailMaxLength = 60;
    }
}
