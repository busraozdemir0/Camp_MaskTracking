using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Cıplak class kalmamali
    public class PersonManager:IApplicantService
    {
        public void ApplyForMask(Person person) // maske icin basvur
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        // Mernis'e baglanacak ve belirtilen kisi var mi diye dogrulayacak
        public bool CheckPerson(Person person)
        {
            /* Mernis sistemi merkezi nufus idaresi sistemidir. Bunu projeye dahil ettik. Girilen tc mernis
         sistemindeki tc ile uyusuyorsa boyle bir kisi var demektir. Bu kisi varsa eger buna maske ver. */

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
