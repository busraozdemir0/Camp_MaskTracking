using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService; // field'lar _ ile yazilir

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person) // maske verecek olan operasyon
        {
            if (_applicantService.CheckPerson(person)) // gelen kisi gercekten var mi?
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} için maske verildi.");
            }
            else
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} için maske verilemedi...");
            }
        }
    }
}
