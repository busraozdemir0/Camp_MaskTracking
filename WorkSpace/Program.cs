// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Entities.Concrete;


Person person1 = new Person()
{
    FirstName = "Büşra",
    LastName = "Özdemir",
    DateOfBirthYear = 2002,
    NationalIdentity = 1111 // TC dogru kirildigi takdirde maske verilecektir
};

Person person2 = new Person()
{
    FirstName = "Elif",
    LastName = "Akyüz",
    DateOfBirthYear = 2000,
    NationalIdentity = 999 // Gecersiz
};

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person1);
pttManager.GiveMask(person2);
