using Entities.Concrete;
using Business.Concrete;

Person person1 = new Person();
person1.FirstName = "Can";
person1.LastName = "Demir";
person1.DateOfBirthYear = 1999;
person1.NationalIdentity = 29200887310;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
Console.ReadLine();
