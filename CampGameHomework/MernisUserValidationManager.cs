using MernisUserValidationService;
using System.Threading.Tasks;

namespace CampGameHomework
{
    class MernisUserValidationManager : IUserValidationService
    {
        public bool Validate(IUser gamer)
        {
            return TaskAsync(gamer).Result;
        }

        public static async Task<bool> TaskAsync(IUser gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(gamer.NationalityId,
                gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear));

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
