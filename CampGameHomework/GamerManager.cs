using System;

namespace CampGameHomework
{
    class GamerManager : IGamerService
    {
        bool result = false;
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public bool Add(IUser gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu eklendi");
                return result = true;
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
                return result = false;
            }
            
            
        }
        public void Delete(IUser gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(IUser gamer)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
        public bool Result()
        {
            return result;
        }
    }
}
