namespace CampGameHomework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(IUser gamer)
        {
            if (gamer.FirstName == "HALİL" && gamer.LastName == "TEMEL" && gamer.NationalityId == 12345678910 && gamer.BirthYear == 1991)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
